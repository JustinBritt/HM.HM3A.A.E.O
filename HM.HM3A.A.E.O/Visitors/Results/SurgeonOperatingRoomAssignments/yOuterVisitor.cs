namespace HM.HM3A.A.E.O.Visitors.Results.SurgeonOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;

    internal sealed class yOuterVisitor<TKey, TValue> : IyOuterVisitor<TKey, TValue>
        where TKey : IsIndexElement
        where TValue : RedBlackTree<IrIndexElement, IyResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IyInnerVisitorFactory yInnerVisitorFactory,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.yInnerVisitorFactory = yInnerVisitorFactory;

            this.LocationComparer = locationComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<Organization, RedBlackTree<Location, INullableValue<bool>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IyInnerVisitorFactory yInnerVisitorFactory { get; }

        private ILocationComparer LocationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, IyResultElement> value = obj.Value;

            IyInnerVisitor<IrIndexElement, IyResultElement> innerVisitor = this.yInnerVisitorFactory.Create<IrIndexElement, IyResultElement>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.LocationComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}