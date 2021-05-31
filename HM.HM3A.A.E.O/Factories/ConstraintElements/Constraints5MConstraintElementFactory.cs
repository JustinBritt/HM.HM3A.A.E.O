namespace HM.HM3A.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints5MConstraintElementFactory : IConstraints5MConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5MConstraintElementFactory()
        {
        }

        public IConstraints5MConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Ib b,
            Iy y)
        {
            IConstraints5MConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5MConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    B,
                    b,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}