namespace HM.HM3A.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    public interface ImFactory
    {
        Im Create(
            IRedBlackTreeFactory redBlackTreeFactory,
            IDeviceComparer deviceComparer,
            ImmutableList<ImIndexElement> value);
    }
}