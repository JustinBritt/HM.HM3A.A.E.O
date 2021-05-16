namespace HM.HM3A.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            ImmutableList<IrIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IrIndexElement> Value { get; }
    }
}