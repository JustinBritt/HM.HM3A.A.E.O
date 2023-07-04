namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.Results.BestBound;
    using HM.HM3A.A.E.O.Factories.Results.Gap;
    using HM.HM3A.A.E.O.Factories.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Factories.Results.NumberOfExploredNodes;
    using HM.HM3A.A.E.O.Factories.Results.ObjectiveValue;
    using HM.HM3A.A.E.O.Factories.Results.OverallWallTime;
    using HM.HM3A.A.E.O.Factories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Factories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Factories.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsFactory CreateSurgeonNumberAssignedOperatingRoomsFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IvFactory CreatevFactory()
        {
            IvFactory factory = null;

            try
            {
                factory = new vFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IvOuterVisitorFactory CreatevOuterVisitorFactory()
        {
            IvOuterVisitorFactory factory = null;

            try
            {
                factory = new vOuterVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IwFactory CreatewFactory()
        {
            IwFactory factory = null;

            try
            {
                factory = new wFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IyFactory CreateyFactory()
        {
            IyFactory factory = null;

            try
            {
                factory = new yFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}