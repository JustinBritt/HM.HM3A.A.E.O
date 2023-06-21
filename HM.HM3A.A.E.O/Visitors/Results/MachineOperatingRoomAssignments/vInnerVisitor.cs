namespace HM.HM3A.A.E.O.Visitors.Results.MachineOperatingRoomAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments;

    internal sealed class vInnerVisitor<TKey, TValue> : IvInnerVisitor<TKey, TValue>
        where TKey : IrIndexElement
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vInnerVisitor(
            ILocationComparer locationComparer,
            ImIndexElement mIndexElement,
            Ir r)
        {
            this.mIndexElement = mIndexElement;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<Location, INullableValue<bool>>(
                locationComparer);
        }

        private ImIndexElement mIndexElement { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, INullableValue<bool>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                obj.Value);
        }
    }
}