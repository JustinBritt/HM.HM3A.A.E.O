namespace HM.HM3A.A.E.O.Interfaces.Exports
{
    using System.Threading.Tasks;
    
    using HM.HM3A.A.E.O.Enums;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Configurations;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.SolverConfigurations;
    
    public interface IHM3AExport
    {
        Task<IHM3AOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM3AConfiguration HM3AConfiguration,
            IHM3AInputContext HM3AInputContext,
            ISolverConfiguration solverConfiguration,
            HM3AEncodingEnum HM3AEncodingEnum);
    }
}