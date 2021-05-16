namespace HM.HM3A.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IrtCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}