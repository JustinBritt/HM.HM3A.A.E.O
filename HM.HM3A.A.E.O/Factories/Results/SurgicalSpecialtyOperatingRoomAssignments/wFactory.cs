namespace HM.HM3A.A.E.O.Factories.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Classes.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wFactory : IwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wFactory()
        {
        }

        public Iw Create(
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> value)
        {
            Iw result = null;

            try
            {
                result = new w(
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