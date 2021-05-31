namespace HM.HM3A.A.E.O.Factories.Configurations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM3A.A.E.O.Classes.Configurations;
    using HM.HM3A.A.E.O.Interfaces.Configurations;
    using HM.HM3A.A.E.O.InterfacesFactories.Configurations;

    internal sealed class HM3AConfigurationFactory : IHM3AConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AConfigurationFactory()
        {
        }

        public IHM3AConfiguration Create(
            Configuration configuration)
        {
            IHM3AConfiguration HM3AConfiguration = null;

            try
            {
                HM3AConfiguration = new HM3AConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return HM3AConfiguration;
        }
    }
}