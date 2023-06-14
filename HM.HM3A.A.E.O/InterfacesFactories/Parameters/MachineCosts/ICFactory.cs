namespace HM.HM3A.A.E.O.InterfacesFactories.Parameters.MachineCosts
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;

    public interface ICFactory
    {
        IC Create(
            RedBlackTree<ImIndexElement, ICParameterElement> value);
    }
}