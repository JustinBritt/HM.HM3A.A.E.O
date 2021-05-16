namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Exports;

    public interface IExportsAbstractFactory
    {
        IHM3AExportFactory CreateHM3AExportFactory();
    }
}