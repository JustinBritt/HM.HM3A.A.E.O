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

    internal sealed class ObjectiveFunction010Factory : IObjectiveFunction010Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction010Factory()
        {
        }

        public IObjectiveFunction010 Create(
            IObjectiveFactory objectiveFactory,
            Ijr jr,
            Iw w)
        {
            IObjectiveFunction010 objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction010(
                    objectiveFactory,
                    jr,
                    w);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return objectiveFunction;
        }
    }
}