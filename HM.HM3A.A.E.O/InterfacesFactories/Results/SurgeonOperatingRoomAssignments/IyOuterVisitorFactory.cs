namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;

    public interface IyOuterVisitorFactory
    {
        IyOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IyInnerVisitorFactory yInnerVisitorFactory,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
            where TKey : IsIndexElement
            where TValue : RedBlackTree<IrIndexElement, IyResultElement>;
    }
}