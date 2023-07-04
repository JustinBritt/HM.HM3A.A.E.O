namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwOuterVisitorFactory
    {
        IwOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
            where TKey : IjIndexElement
            where TValue : RedBlackTree<IrIndexElement, IwResultElement>;
    }
}