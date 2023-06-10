namespace HM.HM3A.A.E.O.Classes.Models
{
    using log4net;

    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.Models;

    internal sealed class HM3A010Model : 
        HM3AModel,
        IHM3A010Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3A010Model(
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM3AInputContext HM3AInputContext) :
            base(
                comparersAbstractFactory,
                constraintElementsAbstractFactory,
                constraintsAbstractFactory,
                crossJoinElementsAbstractFactory,
                crossJoinsAbstractFactory,
                dependenciesAbstractFactory,
                indexElementsAbstractFactory,
                indicesAbstractFactory,
                parameterElementsAbstractFactory,
                parametersAbstractFactory,
                variablesAbstractFactory,
                HM3AInputContext)
        {
            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateObjectiveFunction010Factory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.jr,
                    this.w)
                .Value);
        }
    }
}