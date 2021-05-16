namespace HM.HM3A.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes
{
    using HM.HM3A.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}