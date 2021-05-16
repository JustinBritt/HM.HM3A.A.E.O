namespace HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRooms
    {
        ImmutableList<ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}