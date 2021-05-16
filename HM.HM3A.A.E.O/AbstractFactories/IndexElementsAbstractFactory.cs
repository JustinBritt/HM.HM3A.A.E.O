namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.IndexElements;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class IndexElementsAbstractFactory : IIndexElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexElementsAbstractFactory()
        {
        }

        public IjIndexElementFactory CreatejIndexElementFactory()
        {
            IjIndexElementFactory factory = null;

            try
            {
                factory = new jIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ImIndexElementFactory CreatemIndexElementFactory()
        {
            ImIndexElementFactory factory = null;

            try
            {
                factory = new mIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrIndexElementFactory CreaterIndexElementFactory()
        {
            IrIndexElementFactory factory = null;

            try
            {
                factory = new rIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsIndexElementFactory CreatesIndexElementFactory()
        {
            IsIndexElementFactory factory = null;

            try
            {
                factory = new sIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ItIndexElementFactory CreatetIndexElementFactory()
        {
            ItIndexElementFactory factory = null;

            try
            {
                factory = new tIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}