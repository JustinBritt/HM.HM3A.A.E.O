﻿namespace HM.HM3A.A.E.O.Classes.ParameterElements.SurgeonMachineRequirements
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;

    internal sealed class ζParameterElement : IζParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ζParameterElement(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement,
            FhirBoolean value)
        {
            this.sIndexElement = sIndexElement;

            this.mIndexElement = mIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public ImIndexElement mIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}