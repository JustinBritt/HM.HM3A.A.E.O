namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    public interface IParametersAbstractFactory
    {
        HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory CreateBBarFactory();

        HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks.IBFactory CreateBsFactory();

        ICFactory CreateCFactory();

        IΔFactory CreateΔFactory();

        IζFactory CreateζFactory();

        IψFactory CreateψFactory();
    }
}