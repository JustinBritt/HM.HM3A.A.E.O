namespace HM.HM3A.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IsrCrossJoinElementFactory
    {
        IsrCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement);
    }
}