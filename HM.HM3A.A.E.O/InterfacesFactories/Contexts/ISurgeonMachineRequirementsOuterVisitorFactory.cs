namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonMachineRequirementsOuterVisitorFactory
    {
        ISurgeonMachineRequirementsOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            ISurgeonMachineRequirementsInnerVisitorFactory surgeonMachineRequirementsInnerVisitorFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IζParameterElementFactory ζParameterElementFactory,
            Im m,
            Is s)
            where TKey : Organization
            where TValue : RedBlackTree<Device, INullableValue<bool>>;
    }
}