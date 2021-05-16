namespace HM.HM3A.A.E.O.InterfacesFactories.SolverConfigurations
{
    using HM.HM3A.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}