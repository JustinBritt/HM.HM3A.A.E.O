namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;

    public interface IMachineCostsVisitorFactory
    {
        IMachineCostsVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            ICParameterElementFactory CParameterElementFactory,
            Im m)
            where TKey : Device
            where TValue : Money;
    }
}