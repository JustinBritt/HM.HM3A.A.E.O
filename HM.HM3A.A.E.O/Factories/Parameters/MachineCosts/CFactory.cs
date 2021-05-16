namespace HM.HM3A.A.E.O.Factories.Parameters.MachineCosts
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.MachineCosts;

    internal sealed class CFactory : ICFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CFactory()
        {
        }

        public IC Create(
            ImmutableList<ICParameterElement> value)
        {
            IC parameter = null;

            try
            {
                parameter = new C(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}