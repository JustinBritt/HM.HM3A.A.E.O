namespace HM.HM3A.A.E.O.Classes.Results.MachineOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> Value { get; }

        public RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Im m,
            Ir r)
        {
            IvOuterVisitor<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> vOuterVisitor = new HM.HM3A.A.E.O.Visitors.Results.MachineOperatingRoomAssignments.vOuterVisitor<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>>(
                nullableValueFactory,
                new HM.HM3A.A.E.O.Classes.Comparers.DeviceComparer(),
                new HM.HM3A.A.E.O.Classes.Comparers.LocationComparer(),
                m,
                r);

            this.Value.AcceptVisitor(
                vOuterVisitor);

            return vOuterVisitor.RedBlackTree;
        }
    }
}