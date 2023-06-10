namespace HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IBParameterElementFactory
    {
        IBParameterElement Create(
            IjIndexElement jIndexElement,
            INullableValue<int> value);
    }
}