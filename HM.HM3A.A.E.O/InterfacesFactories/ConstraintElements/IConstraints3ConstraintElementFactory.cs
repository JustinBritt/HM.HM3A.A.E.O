namespace HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IConstraints3ConstraintElementFactory
    {
        IConstraints3ConstraintElement Create(
            IrIndexElement rIndexElement,
            Is s,
            It t,
            Ib b,
            Iγ γ);
    }
}