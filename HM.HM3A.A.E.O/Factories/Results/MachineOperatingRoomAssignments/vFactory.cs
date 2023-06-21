namespace HM.HM3A.A.E.O.Factories.Results.MachineOperatingRoomAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Classes.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments;

    internal sealed class vFactory : IvFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vFactory()
        {
        }

        public Iv Create(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> value)
        {
            Iv result = null;

            try
            {
                result = new v(
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