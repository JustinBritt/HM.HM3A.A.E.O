﻿namespace HM.HM3A.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    internal sealed class jIndexElement : IjIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the surgical specialty.
        /// </summary>
        public Organization Value { get; }

        public int CompareTo(
            IjIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}