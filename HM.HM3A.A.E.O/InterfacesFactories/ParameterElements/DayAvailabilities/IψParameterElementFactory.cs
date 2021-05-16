namespace HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.DayAvailabilities;

    public interface IψParameterElementFactory
    {
        IψParameterElement Create(
            ItIndexElement tIndexElement,
            FhirBoolean value);
    }
}