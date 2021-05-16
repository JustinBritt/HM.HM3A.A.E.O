namespace HM.HM3A.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class jrCrossJoinElementFactory : IjrCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jrCrossJoinElementFactory()
        {
        }

        public IjrCrossJoinElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement)
        {
            IjrCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new jrCrossJoinElement(
                    jIndexElement,
                    rIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}