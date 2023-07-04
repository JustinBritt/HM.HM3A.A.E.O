namespace HM.HM3A.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3A.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonMachineRequirementsInnerVisitorFactory : ISurgeonMachineRequirementsInnerVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMachineRequirementsInnerVisitorFactory()
        {
        }

        public ISurgeonMachineRequirementsInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IζParameterElementFactory ζParameterElementFactory,
            IsIndexElement sIndexElement,
            Im m)
            where TKey : Device
            where TValue : INullableValue<bool>
        {
            ISurgeonMachineRequirementsInnerVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonMachineRequirementsInnerVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    ζParameterElementFactory,
                    sIndexElement,
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