﻿namespace HM.HM3A.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    internal sealed class mIndexElement : ImIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mIndexElement(
            Device value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the machine.
        /// </summary>
        public Device Value { get; }

        public int CompareTo(
            ImIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}