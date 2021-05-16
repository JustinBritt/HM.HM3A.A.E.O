namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;

    public interface IyFactory
    {
        Iy Create(
            ImmutableList<IyResultElement> value);
    }
}