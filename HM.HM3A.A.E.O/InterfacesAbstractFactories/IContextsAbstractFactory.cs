namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IHM3AInputContextFactory CreateHM3AInputContextFactory();

        IHM3AOutputContextFactory CreateHM3AOutputContextFactory();
    }
}