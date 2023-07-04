namespace HM.HM3A.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3A.A.E.O.Visitors.Contexts;
    
    internal sealed class SurgeonMachineRequirementsOuterVisitorFactory : ISurgeonMachineRequirementsOuterVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMachineRequirementsOuterVisitorFactory()
        {
        }

        public ISurgeonMachineRequirementsOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            ISurgeonMachineRequirementsInnerVisitorFactory surgeonMachineRequirementsInnerVisitorFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IζParameterElementFactory ζParameterElementFactory,
            Im m,
            Is s)
            where TKey : Organization
            where TValue : RedBlackTree<Device, INullableValue<bool>>
        {
            ISurgeonMachineRequirementsOuterVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonMachineRequirementsOuterVisitor<TKey, TValue>(
                    surgeonMachineRequirementsInnerVisitorFactory,
                    redBlackTreeFactory,
                    ζParameterElementFactory,
                    m,
                    s);
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