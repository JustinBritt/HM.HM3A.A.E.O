namespace HM.HM3A.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface ImrCrossJoinElement
    {
        ImIndexElement mIndexElement { get; }

        IrIndexElement rIndexElement { get; }
    }
}