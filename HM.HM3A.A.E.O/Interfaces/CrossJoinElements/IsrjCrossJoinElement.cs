namespace HM.HM3A.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IsrjCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        IjIndexElement jIndexElement { get; }
    }
}