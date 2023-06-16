namespace HM.HM3A.A.E.O.Classes.Comparers
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Comparers;

    internal sealed class LocationComparer : ILocationComparer
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LocationComparer()
        {
        }

        public int Compare(
            Location x,
            Location y)
        {
            return String.CompareOrdinal(
                x.Id,
                y.Id);
        }
    }
}