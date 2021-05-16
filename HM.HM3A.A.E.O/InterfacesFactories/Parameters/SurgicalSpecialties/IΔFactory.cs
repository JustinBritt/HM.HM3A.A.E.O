namespace HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    public interface IΔFactory
    {
        IΔ Create(
            ImmutableList<IΔParameterElement> value);
    }
}