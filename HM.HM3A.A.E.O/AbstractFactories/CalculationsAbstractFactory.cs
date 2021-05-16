namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}