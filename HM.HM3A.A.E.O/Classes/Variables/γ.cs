namespace HM.HM3A.A.E.O.Classes.Variables
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            VariableCollection<IrIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IrIndexElement, ItIndexElement> Value { get; }
    }
}