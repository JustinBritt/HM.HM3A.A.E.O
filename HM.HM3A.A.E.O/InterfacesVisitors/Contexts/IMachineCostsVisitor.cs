namespace HM.HM3A.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;

    public interface IMachineCostsVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Device
        where TValue : Money
    {
        RedBlackTree<ImIndexElement, ICParameterElement> RedBlackTree { get; }
    }
}