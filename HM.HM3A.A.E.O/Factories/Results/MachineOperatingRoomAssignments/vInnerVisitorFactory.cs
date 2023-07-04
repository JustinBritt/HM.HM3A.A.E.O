namespace HM.HM3A.A.E.O.Factories.Results.MachineOperatingRoomAssignments
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Visitors.Results.MachineOperatingRoomAssignments;

    internal sealed class vInnerVisitorFactory : IvInnerVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vInnerVisitorFactory()
        {
        }

        public IvInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer)
            where TKey : IrIndexElement
            where TValue : IvResultElement
        {
            IvInnerVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new vInnerVisitor<TKey, TValue>(
                    nullableValueFactory,
                    redBlackTreeFactory,
                    locationComparer);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}