namespace HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IBParameterElement
    {
        IjIndexElement jIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}