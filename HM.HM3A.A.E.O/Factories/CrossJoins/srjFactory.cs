﻿namespace HM.HM3A.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Classes.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class srjFactory : IsrjFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srjFactory()
        {
        }

        public Isrj Create(
            ImmutableList<IsrjCrossJoinElement> value)
        {
            Isrj crossJoin = null;

            try
            {
                crossJoin = new srj(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}