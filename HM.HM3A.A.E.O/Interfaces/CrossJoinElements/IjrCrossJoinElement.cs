namespace HM.HM3A.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IjrCrossJoinElement
    {
        IjIndexElement jIndexElement { get; }

        IrIndexElement rIndexElement { get; }
    }
}