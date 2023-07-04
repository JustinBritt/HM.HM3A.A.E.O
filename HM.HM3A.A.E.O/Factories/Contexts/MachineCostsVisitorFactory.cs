namespace HM.HM3A.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3A.A.E.O.Visitors.Contexts;

    internal sealed class MachineCostsVisitorFactory : IMachineCostsVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MachineCostsVisitorFactory()
        {
        }

        public IMachineCostsVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            ICParameterElementFactory CParameterElementFactory,
            Im m)
            where TKey : Device
            where TValue : Money
        {
            IMachineCostsVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new MachineCostsVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    CParameterElementFactory,
                    m);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}