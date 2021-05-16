namespace HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IConstraints5LConstraintElementFactory
    {
        IConstraints5LConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Ib b,
            Iy y);
    }
}