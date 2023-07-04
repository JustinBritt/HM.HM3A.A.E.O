namespace HM.HM3A.A.E.O.Classes.Results.SurgeonOperatingRoomAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;

    internal sealed class y : Iy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public y(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            ILocationComparerFactory locationComparerFactory,
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IyInnerVisitorFactory yInnerVisitorFactory,
            IyOuterVisitorFactory yOuterVisitorFactory)
        {
            IyOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> yOuterVisitor = new HM.HM3A.A.E.O.Visitors.Results.SurgeonOperatingRoomAssignments.yOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>>(
                nullableValueFactory,
                redBlackTreeFactory,
                yInnerVisitorFactory,
                locationComparerFactory.Create(),
                organizationComparerFactory.Create());

            this.Value.AcceptVisitor(
                yOuterVisitor);

            return yOuterVisitor.RedBlackTree;
        }
    }
}