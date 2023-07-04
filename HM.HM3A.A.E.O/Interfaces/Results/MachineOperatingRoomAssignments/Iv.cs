namespace HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    public interface Iv
    {
        RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> Value { get; }

        RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            IDeviceComparerFactory deviceComparerFactory,
            ILocationComparerFactory locationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            Im m,
            Ir r);
    }
}