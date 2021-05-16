namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    public interface IParameterElementsAbstractFactory
    {
        HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBParameterElementFactory CreateBBarParameterElementFactory();

        HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks.IBParameterElementFactory CreateBsParameterElementFactory();

        ICParameterElementFactory CreateCParameterElementFactory();

        IΔParameterElementFactory CreateΔParameterElementFactory();

        IζParameterElementFactory CreateζParameterElementFactory();

        IψParameterElementFactory CreateψParameterElementFactory();
    }
}