namespace HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;

    public interface IC
    {
        ImmutableList<ICParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            ImIndexElement mIndexElement);
    }
}