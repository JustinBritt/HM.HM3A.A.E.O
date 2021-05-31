namespace HM.HM3A.A.E.O.Factories.ResultElements.MachineOperatingRoomAssignments
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.MachineOperatingRoomAssignments;

    internal sealed class vResultElementFactory : IvResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vResultElementFactory()
        {
        }

        public IvResultElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            bool value)
        {
            IvResultElement resultElement = null;

            try
            {
                resultElement = new vResultElement(
                    mIndexElement,
                    rIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}