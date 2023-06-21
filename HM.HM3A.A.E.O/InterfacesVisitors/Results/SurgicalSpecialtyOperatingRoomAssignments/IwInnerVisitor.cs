namespace HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IrIndexElement
        where TValue : IwResultElement
    {
        RedBlackTree<Location, INullableValue<bool>> RedBlackTree { get; }
    }
}