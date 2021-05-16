namespace HM.HM3A.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.Constraints;

    public interface IConstraints5UFactory
    {
        IConstraints5U Create(
            ImmutableList<IConstraints5UConstraintElement> value);
    }
}