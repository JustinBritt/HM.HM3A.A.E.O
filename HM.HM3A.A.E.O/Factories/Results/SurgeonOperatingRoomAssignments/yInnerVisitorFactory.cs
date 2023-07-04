namespace HM.HM3A.A.E.O.Factories.Results.SurgeonOperatingRoomAssignments
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Visitors.Results.SurgeonOperatingRoomAssignments;

    internal sealed class yInnerVisitorFactory : IyInnerVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yInnerVisitorFactory()
        {
        }

        public IyInnerVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer)
            where TKey : IrIndexElement
            where TValue : IyResultElement
        {
            IyInnerVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new yInnerVisitor<TKey, TValue>(
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