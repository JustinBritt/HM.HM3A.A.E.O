namespace HM.HM3A.A.E.O.Classes.ParameterElements.MachineCosts
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;

    internal sealed class CParameterElement : ICParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CParameterElement(
            ImIndexElement mIndexElement,
            Money value)
        {
            this.mIndexElement = mIndexElement;

            this.Value = value;
        }

        public ImIndexElement mIndexElement { get; }

        public Money Value { get; }
    }
}