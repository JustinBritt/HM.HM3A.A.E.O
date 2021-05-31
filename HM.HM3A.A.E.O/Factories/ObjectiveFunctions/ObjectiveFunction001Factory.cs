namespace HM.HM3A.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM3A.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunction001Factory : IObjectiveFunction001Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction001Factory()
        {
        }

        public IObjectiveFunction001 Create(
            IObjectiveFactory objectiveFactory,
            Isr sr,
            Iy y)
        {
            IObjectiveFunction001 objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction001(
                    objectiveFactory,
                    sr,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}