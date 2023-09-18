namespace HM.HM3A.A.E.O.Classes.Results.SurgeonNumberAssignedOperatingRooms
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonNumberAssignedOperatingRooms : ISurgeonNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRooms(
            RedBlackTree<IsIndexElement, ISurgeonNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, ISurgeonNumberAssignedOperatingRoomsResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new(
                organizationComparerFactory.Create());

            foreach (ISurgeonNumberAssignedOperatingRoomsResultElement surgeonNumberAssignedOperatingRoomsResultElement in this.Value.Values)
            {
                redBlackTree.Add(
                    surgeonNumberAssignedOperatingRoomsResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgeonNumberAssignedOperatingRoomsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}