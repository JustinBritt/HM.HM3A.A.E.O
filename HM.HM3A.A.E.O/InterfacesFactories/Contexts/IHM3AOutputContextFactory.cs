namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Enums;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.Models;

    public interface IHM3AOutputContextFactory
    {
        IHM3AOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM3AModel HM3AModel,
            Solution solution,
            HM3AEncodingEnum HM3AEncodingEnum);
    }
}