namespace HM.HM3A.A.E.O.Classes.ResultElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using log4net;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wResultElement : IwResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wResultElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            bool value)
        {
            this.jIndexElement = jIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public bool Value { get; }
    }
}