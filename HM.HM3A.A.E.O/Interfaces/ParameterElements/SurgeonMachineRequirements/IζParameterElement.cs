namespace HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IζParameterElement
    {
        IsIndexElement sIndexElement { get; }

        ImIndexElement mIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}