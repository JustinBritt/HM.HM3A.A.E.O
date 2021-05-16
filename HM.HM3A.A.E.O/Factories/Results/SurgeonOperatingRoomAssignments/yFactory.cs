﻿namespace HM.HM3A.A.E.O.Factories.Results.SurgeonOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;

    internal sealed class yFactory : IyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yFactory()
        {
        }

        public Iy Create(
            ImmutableList<IyResultElement> value)
        {
            Iy result = null;

            try
            {
                result = new y(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}