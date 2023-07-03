namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;

    public interface IDayAvailabilitiesVisitorFactory
    {
        IDayAvailabilitiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IψParameterElementFactory ψParameterElementFactory,
            It t)
            where TKey : FhirDateTime
            where TValue : INullableValue<bool>;
    }
}