namespace HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;

    public interface ICParameterElementFactory
    {
        ICParameterElement Create(
            ImIndexElement mIndexElement,
            Money value);
    }
}