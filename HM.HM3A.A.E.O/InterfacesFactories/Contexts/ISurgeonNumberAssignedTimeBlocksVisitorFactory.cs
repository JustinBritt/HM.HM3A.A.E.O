namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;

    public interface ISurgeonNumberAssignedTimeBlocksVisitorFactory
    {
        ISurgeonNumberAssignedTimeBlocksVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IBParameterElementFactory BParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<int>;
    }
}