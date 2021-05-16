﻿namespace HM.HM3A.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Classes.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class mrFactory : ImrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mrFactory()
        {
        }

        public Imr Create(
            ImmutableList<ImrCrossJoinElement> value)
        {
            Imr crossJoin = null;

            try
            {
                crossJoin = new mr(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoin;
        }
    }
}