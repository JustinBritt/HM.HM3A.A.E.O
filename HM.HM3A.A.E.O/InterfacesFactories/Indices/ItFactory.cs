namespace HM.HM3A.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;

    public interface ItFactory
    {
        It Create(
            ImmutableList<ItIndexElement> value);
    }
}