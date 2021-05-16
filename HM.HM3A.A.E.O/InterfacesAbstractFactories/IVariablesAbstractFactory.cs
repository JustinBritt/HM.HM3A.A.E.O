namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Variables;

    public interface IVariablesAbstractFactory
    {
        IbFactory CreatebFactory();

        IvFactory CreatevFactory();

        IwFactory CreatewFactory();

        IyFactory CreateyFactory();

        IγFactory CreateγFactory();
    }
}