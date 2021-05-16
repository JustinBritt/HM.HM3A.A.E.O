namespace HM.HM3A.A.E.O.Interfaces.ParameterElements.DayAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IψParameterElement
    {
        ItIndexElement tIndexElement { get; }

        FhirBoolean Value { get; }
    }
}