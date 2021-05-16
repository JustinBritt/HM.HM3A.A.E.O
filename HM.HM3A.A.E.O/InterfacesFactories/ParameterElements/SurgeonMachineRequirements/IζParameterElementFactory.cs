namespace HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;

    public interface IζParameterElementFactory
    {
        IζParameterElement Create(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement,
            FhirBoolean value);
    }
}