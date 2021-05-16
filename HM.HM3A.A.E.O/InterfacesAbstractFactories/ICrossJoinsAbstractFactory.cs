namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.CrossJoins;

    public interface ICrossJoinsAbstractFactory
    {
        IjrFactory CreatejrFactory();

        ImrFactory CreatemrFactory();

        IrtFactory CreatertFactory();

        IsrFactory CreatesrFactory();

        IsrjFactory CreatesrjFactory();
    }
}