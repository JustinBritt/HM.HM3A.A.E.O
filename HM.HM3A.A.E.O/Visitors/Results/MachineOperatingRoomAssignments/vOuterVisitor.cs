namespace HM.HM3A.A.E.O.Visitors.Results.MachineOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments;
    
    internal sealed class vOuterVisitor<TKey, TValue> : IvOuterVisitor<TKey, TValue>
        where TKey : ImIndexElement
        where TValue : RedBlackTree<IrIndexElement, IvResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IDeviceComparer deviceComparer,
            ILocationComparer locationComparer,
            Im m,
            Ir r)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.LocationComparer = locationComparer;

            this.m = m;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>>(
                deviceComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private ILocationComparer LocationComparer { get; }

        private Im m { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ImIndexElement mIndexElement = obj.Key;

            RedBlackTree<IrIndexElement, IvResultElement> value = obj.Value;

            var innerVisitor = new vInnerVisitor<IrIndexElement, IvResultElement>(
                this.NullableValueFactory,
                this.LocationComparer,
                this.r);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                mIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}