namespace HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IBParameterElement
    {
        IsIndexElement sIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}