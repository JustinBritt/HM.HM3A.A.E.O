namespace HM.HM3A.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface ImrCrossJoinElementFactory
    {
        ImrCrossJoinElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement);
    }
}