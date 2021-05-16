namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.Constraints;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.Constraints;

    internal sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public IConstraints1Factory CreateConstraints1Factory()
        {
            IConstraints1Factory factory = null;

            try
            {
                factory = new Constraints1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints2Factory CreateConstraints2Factory()
        {
            IConstraints2Factory factory = null;

            try
            {
                factory = new Constraints2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints3Factory CreateConstraints3Factory()
        {
            IConstraints3Factory factory = null;

            try
            {
                factory = new Constraints3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints4Factory CreateConstraints4Factory()
        {
            IConstraints4Factory factory = null;

            try
            {
                factory = new Constraints4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints5LFactory CreateConstraints5LFactory()
        {
            IConstraints5LFactory factory = null;

            try
            {
                factory = new Constraints5LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints5MFactory CreateConstraints5MFactory()
        {
            IConstraints5MFactory factory = null;

            try
            {
                factory = new Constraints5MFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints5UFactory CreateConstraints5UFactory()
        {
            IConstraints5UFactory factory = null;

            try
            {
                factory = new Constraints5UFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}