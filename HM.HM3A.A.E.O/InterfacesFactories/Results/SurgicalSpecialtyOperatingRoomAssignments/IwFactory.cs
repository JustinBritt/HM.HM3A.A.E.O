namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwFactory
    {
        Iw Create(
            ImmutableList<IwResultElement> value);
    }
}