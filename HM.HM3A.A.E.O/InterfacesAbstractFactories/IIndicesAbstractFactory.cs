namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Indices;

    public interface IIndicesAbstractFactory
    {
        IjFactory CreatejFactory();

        ImFactory CreatemFactory();

        IrFactory CreaterFactory();

        IsFactory CreatesFactory();

        ItFactory CreatetFactory();
    }
}