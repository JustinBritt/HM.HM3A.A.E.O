namespace HM.HM3A.A.E.O.Classes.Results.MachineOperatingRoomAssignments
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> Value { get; }

        public ImmutableList<Tuple<Device, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            List<Tuple<Device, Location, INullableValue<bool>>> list = new List<Tuple<Device, Location, INullableValue<bool>>>();

            foreach (var item in this.Value.Values.Distinct())
            {
                foreach (var item2 in item.Values.Distinct())
                {
                    list.Add(
                        Tuple.Create(
                            item2.mIndexElement.Value,
                            item2.rIndexElement.Value,
                            nullableValueFactory.Create<bool>(
                                item2.Value)));
                }
            }

            return list.ToImmutableList();
        }
    }
}