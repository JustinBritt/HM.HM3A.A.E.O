namespace HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    public interface IBParameterElementFactory
    {
        IBParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value);
    }
}