namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        IGapFactory CreateGapFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        ISurgeonNumberAssignedOperatingRoomsFactory CreateSurgeonNumberAssignedOperatingRoomsFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory();

        IvFactory CreatevFactory();

        IvInnerVisitorFactory CreatevInnerVisitorFactory();

        IvOuterVisitorFactory CreatevOuterVisitorFactory();

        IwFactory CreatewFactory();

        IwOuterVisitorFactory CreatewOuterVisitorFactory();

        IyFactory CreateyFactory();

        IyOuterVisitorFactory CreateyOuterVisitorFactory();
    }
}