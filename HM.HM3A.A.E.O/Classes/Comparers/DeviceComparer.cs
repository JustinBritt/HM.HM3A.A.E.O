namespace HM.HM3A.A.E.O.Classes.Comparers
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Comparers;

    internal sealed class DeviceComparer : IDeviceComparer
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeviceComparer()
        {
        }

        public int Compare(
            Device x,
            Device y)
        {
            return String.CompareOrdinal(
                x.Id,
                y.Id);
        }
    }
}