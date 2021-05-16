namespace HM.HM3A.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.CrossJoinElements;

    public interface Ijr
    {
        ImmutableList<IjrCrossJoinElement> Value { get; }
    }
}