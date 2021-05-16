namespace HM.HM3A.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IObjectiveFunction010Factory
    {
        IObjectiveFunction010 Create(
            IObjectiveFactory objectiveFactory,
            Ijr jr,
            Iw w);
    }
}