namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.CrossJoinElements;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public IjrCrossJoinElementFactory CreatejrCrossJoinElementFactory()
        {
            IjrCrossJoinElementFactory factory = null;

            try
            {
                factory = new jrCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ImrCrossJoinElementFactory CreatemrCrossJoinElementFactory()
        {
            ImrCrossJoinElementFactory factory = null;

            try
            {
                factory = new mrCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrtCrossJoinElementFactory CreatertCrossJoinElementFactory()
        {
            IrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new rtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory()
        {
            IsrCrossJoinElementFactory factory = null;

            try
            {
                factory = new srCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrjCrossJoinElementFactory CreatesrjCrossJoinElementFactory()
        {
            IsrjCrossJoinElementFactory factory = null;

            try
            {
                factory = new srjCrossJoinElementFactory();
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