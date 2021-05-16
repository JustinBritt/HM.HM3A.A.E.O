namespace HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments;

    public interface IvFactory
    {
        Iv Create(
            ImmutableList<IvResultElement> value);
    }
}