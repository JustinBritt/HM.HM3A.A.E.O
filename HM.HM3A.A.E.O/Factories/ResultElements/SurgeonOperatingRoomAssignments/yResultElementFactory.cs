﻿namespace HM.HM3A.A.E.O.Factories.ResultElements.SurgeonOperatingRoomAssignments
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;

    internal sealed class yResultElementFactory : IyResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yResultElementFactory()
        {
        }

        public IyResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            bool value)
        {
            IyResultElement resultElement = null;

            try
            {
                resultElement = new yResultElement(
                    sIndexElement,
                    rIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}