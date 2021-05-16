namespace HM.HM3A.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface Ir
    {
        ImmutableList<IrIndexElement> Value { get; }
    }
}