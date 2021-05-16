namespace HM.HM3A.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    internal sealed class jrCrossJoinElement : IjrCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jrCrossJoinElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement)
        {
            this.jIndexElement = jIndexElement;

            this.rIndexElement = rIndexElement;
        }

        public IjIndexElement jIndexElement { get; }

        public IrIndexElement rIndexElement { get; }
    }
}