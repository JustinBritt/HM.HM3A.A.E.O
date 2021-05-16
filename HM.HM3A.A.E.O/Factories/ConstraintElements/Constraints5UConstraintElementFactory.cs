namespace HM.HM3A.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints5UConstraintElementFactory : IConstraints5UConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5UConstraintElementFactory()
        {
        }

        public IConstraints5UConstraintElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Iw w,
            Iy y)
        {
            IConstraints5UConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5UConstraintElement(
                    jIndexElement,
                    rIndexElement,
                    sIndexElement,
                    BBar,
                    Bs,
                    w,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}