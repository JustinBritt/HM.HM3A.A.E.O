namespace HM.HM3A.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5UConstraintElement : IConstraints5UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5UConstraintElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Iw w,
            Iy y)
        {
            Expression LHS = Bs.GetElementAtAsint(
                sIndexElement)
                *
                y.Value[sIndexElement, rIndexElement];

            Expression RHS = BBar.GetElementAtAsint(
                jIndexElement)
                *
                w.Value[jIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}