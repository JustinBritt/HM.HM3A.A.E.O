namespace HM.HM3A.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Constraints;
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.Constraints;
    using HM.HM3A.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints5LFactory : IConstraints5LFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5LFactory()
        {
        }

        public IConstraints5L Create(
            ImmutableList<IConstraints5LConstraintElement> value)
        {
            IConstraints5L constraint = null;

            try
            {
                constraint = new Constraints5L(
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