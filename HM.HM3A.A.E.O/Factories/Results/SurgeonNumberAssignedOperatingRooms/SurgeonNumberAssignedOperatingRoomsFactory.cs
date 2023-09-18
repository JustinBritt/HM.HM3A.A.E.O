namespace HM.HM3A.A.E.O.Factories.Results.SurgeonNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Classes.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    
    internal sealed class SurgeonNumberAssignedOperatingRoomsFactory : ISurgeonNumberAssignedOperatingRoomsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRooms Create(
            RedBlackTree<IsIndexElement, ISurgeonNumberAssignedOperatingRoomsResultElement> value)
        {
            ISurgeonNumberAssignedOperatingRooms result = null;

            try
            {
                result = new SurgeonNumberAssignedOperatingRooms(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}