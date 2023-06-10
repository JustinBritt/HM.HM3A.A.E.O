namespace HM.HM3A.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    internal sealed class sIndexElement : IsIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the surgeon.
        /// </summary>
        public Organization Value { get; }

        public int CompareTo(
            IsIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}