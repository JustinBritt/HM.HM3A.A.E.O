namespace HM.HM3A.A.E.O.Classes.Exports
{
    using System.Threading.Tasks;

    using log4net;

    using HM.HM3A.A.E.O.Enums;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Configurations;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.Exports;
    using HM.HM3A.A.E.O.Interfaces.SolverConfigurations;

    public sealed class HM3AExport : IHM3AExport
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AExport()
        {
        }

        public Task<IHM3AOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM3AConfiguration HM3AConfiguration,
            IHM3AInputContext HM3AInputContext,
            ISolverConfiguration solverConfiguration,
            HM3AEncodingEnum HM3AEncodingEnum)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateHM3ASolutionFactory().Create().Solve(
                abstractFactory.CreateCalculationsAbstractFactory(),
                abstractFactory.CreateConstraintElementsAbstractFactory(),
                abstractFactory.CreateConstraintsAbstractFactory(),
                abstractFactory.CreateContextsAbstractFactory(),
                abstractFactory.CreateCrossJoinElementsAbstractFactory(),
                abstractFactory.CreateCrossJoinsAbstractFactory(),
                abstractFactory.CreateDependenciesAbstractFactory(),
                abstractFactory.CreateIndexElementsAbstractFactory(),
                abstractFactory.CreateIndicesAbstractFactory(),
                abstractFactory.CreateModelsAbstractFactory(),
                abstractFactory.CreateObjectiveFunctionsAbstractFactory(),
                abstractFactory.CreateParameterElementsAbstractFactory(),
                abstractFactory.CreateParametersAbstractFactory(),
                abstractFactory.CreateResultElementsAbstractFactory(),
                abstractFactory.CreateResultsAbstractFactory(),
                abstractFactory.CreateVariablesAbstractFactory(),
                HM3AConfiguration,
                HM3AInputContext,
                solverConfiguration,
                HM3AEncodingEnum);
        }
    }
}