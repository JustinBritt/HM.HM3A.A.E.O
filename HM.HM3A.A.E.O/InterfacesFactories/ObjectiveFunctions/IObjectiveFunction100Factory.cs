namespace HM.HM3A.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IObjectiveFunction100Factory
    {
        IObjectiveFunction100 Create(
            IObjectiveFactory objectiveFactory,
            Imr mr,
            IC C,
            Iv v);
    }
}