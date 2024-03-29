﻿namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IDayAvailabilitiesVisitorFactory CreateDayAvailabilitiesVisitorFactory();

        IHM3AInputContextFactory CreateHM3AInputContextFactory();

        IHM3AOutputContextFactory CreateHM3AOutputContextFactory();

        IMachineCostsVisitorFactory CreateMachineCostsVisitorFactory();

        IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory();

        ISurgeonMachineRequirementsInnerVisitorFactory CreateSurgeonMachineRequirementsInnerVisitorFactory();

        ISurgeonMachineRequirementsOuterVisitorFactory CreateSurgeonMachineRequirementsOuterVisitorFactory();

        ISurgeonNumberAssignedTimeBlocksVisitorFactory CreateSurgeonNumberAssignedTimeBlocksVisitorFactory();

        ISurgicalSpecialtiesVisitorFactory CreateSurgicalSpecialtiesVisitorFactory();

        ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory CreateSurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory();
    }
}