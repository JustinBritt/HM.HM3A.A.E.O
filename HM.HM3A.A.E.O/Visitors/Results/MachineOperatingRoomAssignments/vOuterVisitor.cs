namespace HM.HM3A.A.E.O.Visitors.Results.MachineOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments;
    
    internal sealed class vOuterVisitor<TKey, TValue> : IvOuterVisitor<TKey, TValue>
        where TKey : ImIndexElement
        where TValue : RedBlackTree<IrIndexElement, IvResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IDeviceComparer deviceComparer,
            ILocationComparer locationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.LocationComparer = locationComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<Device, RedBlackTree<Location, INullableValue<bool>>>(
                deviceComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private ILocationComparer LocationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ImIndexElement mIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, IvResultElement> value = obj.Value;

            var innerVisitor = new vInnerVisitor<IrIndexElement, IvResultElement>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.LocationComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                mIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}