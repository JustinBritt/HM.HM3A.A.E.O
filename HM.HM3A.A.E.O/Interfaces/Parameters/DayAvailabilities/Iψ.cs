namespace HM.HM3A.A.E.O.Interfaces.Parameters.DayAvailabilities
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.DayAvailabilities;

    public interface Iψ
    {
        ImmutableList<IψParameterElement> Value { get; }

        int GetElementAtAsint(
            ItIndexElement tIndexElement);
    }
}