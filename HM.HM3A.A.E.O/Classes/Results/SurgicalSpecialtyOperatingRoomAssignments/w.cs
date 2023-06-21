namespace HM.HM3A.A.E.O.Classes.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> Value { get; }

        public ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            List<Tuple<Organization, Location, INullableValue<bool>>> list = new List<Tuple<Organization, Location, INullableValue<bool>>>();

            foreach (var item in this.Value.Values.Distinct())
            {
                foreach (var item2 in item.Values.Distinct())
                {
                    list.Add(
                        Tuple.Create(
                            item2.jIndexElement.Value,
                            item2.rIndexElement.Value,
                            nullableValueFactory.Create<bool>(
                                item2.Value)));
                }
            }

            return list.ToImmutableList();
        }
    }
}