namespace HM.HM3A.A.E.O.Classes.Parameters.MachineCosts
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;

    internal sealed class C : IC
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public C(
            RedBlackTree<ImIndexElement, ICParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<ImIndexElement, ICParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            ImIndexElement mIndexElement)
        {
            return this.Value[mIndexElement].Value.Value.Value;
        }
    }
}