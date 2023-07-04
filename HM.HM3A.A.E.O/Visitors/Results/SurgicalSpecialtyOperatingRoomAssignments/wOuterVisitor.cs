namespace HM.HM3A.A.E.O.Visitors.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wOuterVisitor<TKey, TValue> : IwOuterVisitor<TKey, TValue>
        where TKey : IjIndexElement
        where TValue : RedBlackTree<IrIndexElement, IwResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.LocationComparer = locationComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<Organization, RedBlackTree<Location, INullableValue<bool>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private ILocationComparer LocationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement jIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, IwResultElement> value = obj.Value;

            IwInnerVisitor<IrIndexElement, IwResultElement> innerVisitor = new wInnerVisitor<IrIndexElement, IwResultElement>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.LocationComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                jIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}