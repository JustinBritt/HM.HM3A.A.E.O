namespace HM.HM3A.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    internal sealed class Constraints1ConstraintElement : IConstraints1ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Iζ ζ,
            Iv v,
            Iy y)
        {
            Expression LHS = Expression.Sum(
                s.Value.Values
                .Select(
                    x => y.Value[x, rIndexElement]
                    *
                    ζ.GetElementAtAsint(
                        x,
                        mIndexElement)));

            Expression RHS = m.GetM()
                *
                v.Value[mIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}