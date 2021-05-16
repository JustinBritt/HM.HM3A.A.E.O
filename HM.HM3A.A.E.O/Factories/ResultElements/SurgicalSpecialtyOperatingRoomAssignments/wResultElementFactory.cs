namespace HM.HM3A.A.E.O.Factories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wResultElementFactory : IwResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wResultElementFactory()
        {
        }

        public IwResultElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            bool value)
        {
            IwResultElement resultElement = null;

            try
            {
                resultElement = new wResultElement(
                    jIndexElement,
                    rIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}