namespace HM.HM3A.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Classes.Contexts;
    using HM.HM3A.A.E.O.Enums;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.Models;
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM3AOutputContextFactory : IHM3AOutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AOutputContextFactory()
        {
        }

        public IHM3AOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM3AModel HM3AModel,
            Solution solution,
            HM3AEncodingEnum HM3AEncodingEnum)
        {
            IHM3AOutputContext context = null;

            try
            {
                context = new HM3AOutputContext(
                    calculationsAbstractFactory,
                    comparersAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    HM3AModel,
                    solution,
                    HM3AEncodingEnum);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}