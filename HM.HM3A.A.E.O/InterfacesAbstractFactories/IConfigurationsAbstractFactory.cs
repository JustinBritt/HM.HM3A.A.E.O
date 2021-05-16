namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Configurations;

    public interface IConfigurationsAbstractFactory
    {
        IHM3AConfigurationFactory CreateHM3AConfigurationFactory();
    }
}