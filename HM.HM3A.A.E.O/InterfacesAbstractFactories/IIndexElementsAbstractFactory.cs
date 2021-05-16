namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.IndexElements;

    public interface IIndexElementsAbstractFactory
    {
        IjIndexElementFactory CreatejIndexElementFactory();

        ImIndexElementFactory CreatemIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        ItIndexElementFactory CreatetIndexElementFactory();
    }
}