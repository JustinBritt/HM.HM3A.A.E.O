﻿namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory
    {
        ISurgicalSpecialtyNumberAssignedOperatingRooms Create(
            ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> value);
    }
}