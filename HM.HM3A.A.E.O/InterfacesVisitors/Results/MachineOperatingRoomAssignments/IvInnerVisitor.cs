namespace HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IvInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IrIndexElement
        where TValue : INullableValue<bool>
    {
        RedBlackTree<Location, INullableValue<bool>> RedBlackTree { get; }
    }
}