namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.ConstraintElements;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory()
        {
            IConstraints1ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints1ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory()
        {
            IConstraints2ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints2ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory()
        {
            IConstraints3ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints3ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory()
        {
            IConstraints4ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints4ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5LConstraintElementFactory CreateConstraints5LConstraintElementFactory()
        {
            IConstraints5LConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5LConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5MConstraintElementFactory CreateConstraints5MConstraintElementFactory()
        {
            IConstraints5MConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5MConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5UConstraintElementFactory CreateConstraints5UConstraintElementFactory()
        {
            IConstraints5UConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5UConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}