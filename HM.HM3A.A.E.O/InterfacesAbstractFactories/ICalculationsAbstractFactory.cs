namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ICalculationsAbstractFactory
    {
        ISurgeonNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory();
    }
}