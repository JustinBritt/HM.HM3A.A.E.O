namespace HM.HM3A.A.E.O.InterfacesFactories.Results.BestBound
{
    using HM.HM3A.A.E.O.Interfaces.Results.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}