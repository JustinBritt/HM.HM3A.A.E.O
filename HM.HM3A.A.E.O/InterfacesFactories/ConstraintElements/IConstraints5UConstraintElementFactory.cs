namespace HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IConstraints5UConstraintElementFactory
    {
        IConstraints5UConstraintElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Iw w,
            Iy y);
    }
}