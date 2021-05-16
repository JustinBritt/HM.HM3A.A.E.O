namespace HM.HM3A.A.E.O.Classes.ResultElements.MachineOperatingRoomAssignments
{
    using log4net;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;

    internal sealed class vResultElement : IvResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vResultElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            bool value)
        {
            this.mIndexElement = mIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public ImIndexElement mIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public bool Value { get; }
    }
}