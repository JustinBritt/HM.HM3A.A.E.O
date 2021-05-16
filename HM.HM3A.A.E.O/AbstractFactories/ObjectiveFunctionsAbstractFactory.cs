namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.ObjectiveFunctions;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public IObjectiveFunction001Factory CreateObjectiveFunction001Factory()
        {
            IObjectiveFunction001Factory factory = null;

            try
            {
                factory = new ObjectiveFunction001Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IObjectiveFunction010Factory CreateObjectiveFunction010Factory()
        {
            IObjectiveFunction010Factory factory = null;

            try
            {
                factory = new ObjectiveFunction010Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IObjectiveFunction100Factory CreateObjectiveFunction100Factory()
        {
            IObjectiveFunction100Factory factory = null;

            try
            {
                factory = new ObjectiveFunction100Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}