namespace HM.HM3A.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;
 
    using log4net;

    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.CrossJoins;

    internal sealed class sr : Isr
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sr(
            ImmutableList<IsrCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsrCrossJoinElement> Value { get; }
    }
}