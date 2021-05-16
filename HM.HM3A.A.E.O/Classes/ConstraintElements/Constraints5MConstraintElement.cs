namespace HM.HM3A.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5MConstraintElement : IConstraints5MConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5MConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Ib b,
            Iy y)
        {
            Expression LHS = b.Value[sIndexElement, rIndexElement];

            Expression RHS = B.GetElementAtAsint(
                sIndexElement) 
                * 
                y.Value[sIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}