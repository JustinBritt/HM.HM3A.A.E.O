namespace HM.HM3A.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5LConstraintElement : IConstraints5LConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5LConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Ib b,
            Iy y)
        {
            Expression LHS = y.Value[sIndexElement, rIndexElement];

            Expression RHS = b.Value[sIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}