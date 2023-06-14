namespace HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;

    public interface IC
    {
        RedBlackTree<ImIndexElement, ICParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            ImIndexElement mIndexElement);
    }
}