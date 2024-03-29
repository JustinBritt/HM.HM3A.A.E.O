﻿namespace HM.HM3A.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Constraints;
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.Constraints;
    using HM.HM3A.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints5MFactory : IConstraints5MFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5MFactory()
        {
        }

        public IConstraints5M Create(
            ImmutableList<IConstraints5MConstraintElement> value)
        {
            IConstraints5M constraint = null;

            try
            {
                constraint = new Constraints5M(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}