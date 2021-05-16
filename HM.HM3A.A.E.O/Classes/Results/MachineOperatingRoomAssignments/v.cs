namespace HM.HM3A.A.E.O.Classes.Results.MachineOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            ImmutableList<IvResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IvResultElement> Value { get; }

        public ImmutableList<Tuple<Device, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.mIndexElement.Value,
                    i.rIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}