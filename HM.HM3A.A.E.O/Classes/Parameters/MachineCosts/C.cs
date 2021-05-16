namespace HM.HM3A.A.E.O.Classes.Parameters.MachineCosts
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;

    internal sealed class C : IC
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public C(
            ImmutableList<ICParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ICParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            ImIndexElement mIndexElement)
        {
            return this.Value
                .Where(x => x.mIndexElement == mIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}