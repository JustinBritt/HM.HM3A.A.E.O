namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IHM3AModelFactory CreateHM3AModelFactory();
    }
}