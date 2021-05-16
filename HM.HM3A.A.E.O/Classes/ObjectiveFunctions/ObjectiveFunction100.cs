namespace HM.HM3A.A.E.O.Classes.ObjectiveFunctions
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ObjectiveFunction100 : IObjectiveFunction100
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction100(
            IObjectiveFactory objectiveFactory,
            Imr mr,
            IC C,
            Iv v)
        {
            Expression expression = Expression.Sum(
                mr.Value
                .Select(
                    x => (double)C.GetElementAtAsdecimal(
                        x.mIndexElement)
                    *
                    v.Value[x.mIndexElement, x.rIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}