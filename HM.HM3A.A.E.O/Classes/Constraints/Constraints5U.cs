namespace HM.HM3A.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints5U : IConstraints5U
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5U(
            ImmutableList<IConstraints5UConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints5UConstraintElement> Value { get; }
    }
}