namespace HM.HM3A.A.E.O.InterfacesFactories.Parameters.MachineCosts
{
    using System.Collections.Immutable;
 
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;

    public interface ICFactory
    {
        IC Create(
            ImmutableList<ICParameterElement> value);
    }
}