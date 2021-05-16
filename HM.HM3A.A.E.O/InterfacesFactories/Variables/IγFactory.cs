namespace HM.HM3A.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IγFactory
    {
        Iγ Create(
            VariableCollection<IrIndexElement, ItIndexElement> value);
    }
}