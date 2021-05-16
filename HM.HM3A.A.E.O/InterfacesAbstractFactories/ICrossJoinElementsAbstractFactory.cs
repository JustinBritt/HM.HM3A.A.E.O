namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.CrossJoinElements;

    public interface ICrossJoinElementsAbstractFactory
    {
        IjrCrossJoinElementFactory CreatejrCrossJoinElementFactory();

        ImrCrossJoinElementFactory CreatemrCrossJoinElementFactory();

        IrtCrossJoinElementFactory CreatertCrossJoinElementFactory();

        IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory();

        IsrjCrossJoinElementFactory CreatesrjCrossJoinElementFactory();
    }
}