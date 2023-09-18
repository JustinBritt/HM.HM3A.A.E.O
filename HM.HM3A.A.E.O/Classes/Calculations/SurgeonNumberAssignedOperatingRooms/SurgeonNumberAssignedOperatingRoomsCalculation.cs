namespace HM.HM3A.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    
    internal sealed class SurgeonNumberAssignedOperatingRoomsCalculation : ISurgeonNumberAssignedOperatingRoomsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsCalculation()
        {
        }

        public ISurgeonNumberAssignedOperatingRooms Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            ISurgeonNumberAssignedOperatingRoomsFactory surgeonNumberAssignedOperatingRoomsFactory,
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculation surgeonNumberAssignedOperatingRoomsResultElementCalculation,
            Is s,
            Iy y)
        {
            RedBlackTree<IsIndexElement, ISurgeonNumberAssignedOperatingRoomsResultElement> redBlackTree = new RedBlackTree<IsIndexElement, ISurgeonNumberAssignedOperatingRoomsResultElement>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                redBlackTree.Add(
                    sIndexElement,
                    surgeonNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                        surgeonNumberAssignedOperatingRoomsResultElementFactory,
                        sIndexElement,
                        y));
            }

            return surgeonNumberAssignedOperatingRoomsFactory.Create(
                redBlackTree);
        }
    }
}