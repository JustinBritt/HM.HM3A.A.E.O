namespace HM.HM3A.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM3A.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunction100Factory : IObjectiveFunction100Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction100Factory()
        {
        }

        public IObjectiveFunction100 Create(
            IObjectiveFactory objectiveFactory,
            Imr mr,
            IC C,
            Iv v)
        {
            IObjectiveFunction100 objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction100(
                    objectiveFactory,
                    mr,
                    C,
                    v);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return objectiveFunction;
        }
    }
}