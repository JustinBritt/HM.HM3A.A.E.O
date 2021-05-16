namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Solutions;

    public interface ISolutionsAbstractFactory
    {
        IHM3ASolutionFactory CreateHM3ASolutionFactory();
    }
}