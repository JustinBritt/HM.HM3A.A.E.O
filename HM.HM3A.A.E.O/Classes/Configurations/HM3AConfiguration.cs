namespace HM.HM3A.A.E.O.Classes.Configurations
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM3A.A.E.O.Interfaces.Configurations;

    internal sealed class HM3AConfiguration : IHM3AConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AConfiguration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}