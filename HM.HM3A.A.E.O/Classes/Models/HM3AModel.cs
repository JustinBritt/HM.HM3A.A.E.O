namespace HM.HM3A.A.E.O.Classes.Models
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    internal abstract class HM3AModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AModel(
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM3AInputContext HM3AInputContext)
        {
            this.Context = HM3AInputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.SurgicalSpecialties
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(x))
                .ToImmutableList());

            // m
            this.m = indicesAbstractFactory.CreatemFactory().Create(
                this.Context.Machines
                .Entry
                .Where(x => x.Resource is Device)
                .Select(x => indexElementsAbstractFactory.CreatemIndexElementFactory().Create((Device)x.Resource))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // t
            this.t = indicesAbstractFactory.CreatetFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatetIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // Cross joins

            // jr
            this.jr = crossJoinsAbstractFactory.CreatejrFactory().Create(
                this.j.Value.Values
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatejrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // mr
            this.mr = crossJoinsAbstractFactory.CreatemrFactory().Create(
                this.m.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatemrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rt
            this.rt = crossJoinsAbstractFactory.CreatertFactory().Create(
                this.r.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatertCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sr
            this.sr = crossJoinsAbstractFactory.CreatesrFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // srj
            this.srj = crossJoinsAbstractFactory.CreatesrjFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrjCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // Parameters

            // BBar(j)
            this.BBar = parametersAbstractFactory.CreateBBarFactory().Create(
                this.Context.SurgicalSpecialtyNumberAssignedTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateBBarParameterElementFactory().Create(
                    this.j.GetElementAt(x.Key),
                    (PositiveInt)x.Value))
                .ToImmutableList());

            // B(s)
            this.Bs = parametersAbstractFactory.CreateBsFactory().Create(
                this.Context.SurgeonNumberAssignedTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateBsParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    (PositiveInt)x.Value))
                .ToImmutableList());

            // C(m)
            this.C = parametersAbstractFactory.CreateCFactory().Create(
                this.Context.MachineCosts
                .Select(x => parameterElementsAbstractFactory.CreateCParameterElementFactory().Create(
                    this.m.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // Δ(j)
            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => parameterElementsAbstractFactory.CreateΔParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    x.Item2.Select(i => this.s.GetElementAt(i)).ToImmutableList()))
                .ToImmutableList());

            // ζ(s, m)
            this.ζ = parametersAbstractFactory.CreateζFactory().Create(
                this.Context.SurgeonMachineRequirements
                .Select(x => parameterElementsAbstractFactory.CreateζParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.m.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // ψ(t)
            this.ψ = parametersAbstractFactory.CreateψFactory().Create(
                this.Context.DayAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateψParameterElementFactory().Create(
                    this.t.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // Variables

            // b(s, r)
            this.b = variablesAbstractFactory.CreatebFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model,
                    indexSet1: this.s.Value,
                    indexSet2: this.r.Value,
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => int.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Integer));

            // v(m, r)
            this.v = variablesAbstractFactory.CreatevFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.m.Value,
                    indexSet2: this.r.Value,
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => 1,
                    variableTypeGenerator: (a, b) => VariableType.Binary));

            // w(j, r)
            this.w = variablesAbstractFactory.CreatewFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.j.Value.Values,
                    indexSet2: this.r.Value,
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => 1, 
                    variableTypeGenerator: (a, b) => VariableType.Binary));

            // y(s, r)
            this.y = variablesAbstractFactory.CreateyFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.r.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => 1, 
                    variableTypeGenerator: (a, b) => VariableType.Binary));

            // γ(r, t)
            this.γ = variablesAbstractFactory.CreateγFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.r.Value, 
                    indexSet2: this.t.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => 1, 
                    variableTypeGenerator: (a, b) => VariableType.Binary));

            // Constraints

            // Constraints 1
            this.Model.AddConstraints(
                this.mr.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints1ConstraintElementFactory().Create(
                        x.mIndexElement,
                        x.rIndexElement,
                        this.m,
                        this.s,
                        this.ζ,
                        this.v,
                        this.y)
                    .Value));

            // Constraints 2
            this.Model.AddConstraints(
                this.s.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints2ConstraintElementFactory().Create(
                        x,
                        this.r,
                        this.Bs,
                        this.b)
                    .Value));

            // Constraints 3
            this.Model.AddConstraints(
                this.r.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        x,
                        this.s,
                        this.t,
                        this.b,
                        this.γ)
                    .Value));

            // Constraints 4
            this.Model.AddConstraints(
                this.rt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.tIndexElement,
                        this.ψ,
                        this.γ)
                    .Value));

            // Constraints 5L
            this.Model.AddConstraints(
                this.srj.Value
                .Where(
                    x => this.Δ.IsSurgeonMemberOfSurgicalSpecialty(
                        x.jIndexElement,
                        x.sIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5LConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        this.b,
                        this.y)
                    .Value));

            // Constraints 5M
            this.Model.AddConstraints(
                this.srj.Value
                .Where(
                    x => this.Δ.IsSurgeonMemberOfSurgicalSpecialty(
                        x.jIndexElement,
                        x.sIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5MConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        this.Bs,
                        this.b,
                        this.y)
                    .Value));

            // Constraints 5U
            this.Model.AddConstraints(
                this.srj.Value
                .Where(
                    x => this.Δ.IsSurgeonMemberOfSurgicalSpecialty(
                        x.jIndexElement,
                        x.sIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5UConstraintElementFactory().Create(
                        x.jIndexElement,
                        x.rIndexElement,
                        x.sIndexElement,
                        this.BBar,
                        this.Bs,
                        this.w,
                        this.y)
                    .Value));
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public IHM3AInputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Ij j { get; }

        public Im m { get; }

        public Ir r { get; }

        public Is s { get; }

        public It t { get; }

        public Ijr jr { get; }

        public Imr mr { get; }

        public Irt rt { get; }

        public Isr sr { get; }

        public Isrj srj { get; }

        public Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar { get; }

        public Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs { get; }

        public IC C { get; }

        public IΔ Δ { get; }

        public Iζ ζ { get; }

        public Iψ ψ { get; }

        public Ib b { get; }

        public Iv v { get; }

        public Iw w { get; }

        public Iy y { get; }

        public Iγ γ { get; }
    }
}