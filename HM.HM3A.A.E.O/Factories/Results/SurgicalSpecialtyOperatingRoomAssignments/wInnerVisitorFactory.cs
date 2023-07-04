namespace HM.HM3A.A.E.O.Factories.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Visitors.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wInnerVisitorFactory : IwInnerVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wInnerVisitorFactory()
        {
        }

        public IwInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer)
            where TKey : IrIndexElement
            where TValue : IwResultElement
        {
            IwInnerVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new wInnerVisitor<TKey, TValue>(
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