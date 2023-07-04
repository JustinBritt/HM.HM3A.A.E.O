namespace HM.HM3A.A.E.O.Classes.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            ILocationComparerFactory locationComparerFactory,
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory)
        {
            IwOuterVisitor<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> wOuterVisitor = new HM.HM3A.A.E.O.Visitors.Results.SurgicalSpecialtyOperatingRoomAssignments.wOuterVisitor<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>>(
                nullableValueFactory,
                redBlackTreeFactory,
                locationComparerFactory.Create(),
                organizationComparerFactory.Create());

            this.Value.AcceptVisitor(
                wOuterVisitor);

            return wOuterVisitor.RedBlackTree;
        }
    }
}