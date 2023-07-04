namespace HM.HM3A.A.E.O.Factories.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesVisitors.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Visitors.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wOuterVisitorFactory : IwOuterVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wOuterVisitorFactory()
        {
        }

        public IwOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IwInnerVisitorFactory wInnerVisitorFactory,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
            where TKey : IjIndexElement
            where TValue : RedBlackTree<IrIndexElement, IwResultElement>
        {
            IwOuterVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new wOuterVisitor<TKey, TValue>(
                    nullableValueFactory,
                    redBlackTreeFactory,
                    wInnerVisitorFactory,
                    locationComparer,
                    organizationComparer);
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