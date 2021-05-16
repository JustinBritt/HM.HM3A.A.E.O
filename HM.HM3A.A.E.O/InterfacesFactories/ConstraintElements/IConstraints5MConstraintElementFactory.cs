namespace HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IConstraints5MConstraintElementFactory
    {
        IConstraints5MConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Ib b,
            Iy y);
    }
}