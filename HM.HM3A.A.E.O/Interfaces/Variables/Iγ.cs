namespace HM.HM3A.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface Iγ
    {
        VariableCollection<IrIndexElement, ItIndexElement> Value { get; }
    }
}