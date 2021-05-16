namespace HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IConstraints1ConstraintElementFactory
    {
        IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Iζ ζ,
            Iv v,
            Iy y);
    }
}