namespace HM.HM3A.A.E.O.Classes.ObjectiveFunctions
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ObjectiveFunction001 : IObjectiveFunction001
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction001(
            IObjectiveFactory objectiveFactory,
            Isr sr,
            Iy y)
        {
            Expression expression = Expression.Sum(
                sr.Value
                .Select(
                    x => y.Value[x.sIndexElement, x.rIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}