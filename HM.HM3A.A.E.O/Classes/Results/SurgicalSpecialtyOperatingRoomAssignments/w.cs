namespace HM.HM3A.A.E.O.Classes.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            ImmutableList<IwResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IwResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.jIndexElement.Value,
                    i.rIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}