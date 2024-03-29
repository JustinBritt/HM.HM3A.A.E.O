﻿namespace HM.HM3A.A.E.O.Classes.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BParameterElement : IBParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BParameterElement(
            IjIndexElement jIndexElement,
            INullableValue<int> value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}