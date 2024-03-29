﻿namespace HM.HM3A.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    internal sealed class tIndexElement : ItIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        public int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        public FhirDateTime Value { get; }

        public int CompareTo(
            ItIndexElement other)
        {
            return this.Key.CompareTo(
                other.Key);
        }
    }
}