namespace HM.HM3A.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM3A.A.E.O.Interfaces.Configurations;

    public interface IHM3AConfigurationFactory
    {
        IHM3AConfiguration Create(
            Configuration configuration);
    }
}