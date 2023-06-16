namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IDeviceComparerFactory CreateDeviceComparerFactory();

        IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory();

        ILocationComparerFactory CreateLocationComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}