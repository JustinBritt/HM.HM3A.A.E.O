namespace HM.HM3A.A.E.O.Factories.Results.ObjectiveValue
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Results.ObjectiveValue;
    using HM.HM3A.A.E.O.Interfaces.Results.ObjectiveValue;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.ObjectiveValue;

    internal sealed class ObjectiveValueFactory : IObjectiveValueFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveValueFactory()
        {
        }

        public IObjectiveValue Create(
            decimal value)
        {
            IObjectiveValue result = null;

            try
            {
                result = new ObjectiveValue(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}