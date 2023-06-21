namespace HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IvOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : ImIndexElement
        where TValue : RedBlackTree<IrIndexElement, INullableValue<bool>>
    {
        RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> RedBlackTree { get; }
    }
}