namespace HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface ICParameterElement
    {
        ImIndexElement mIndexElement { get; }

        Money Value { get; }
    }
}