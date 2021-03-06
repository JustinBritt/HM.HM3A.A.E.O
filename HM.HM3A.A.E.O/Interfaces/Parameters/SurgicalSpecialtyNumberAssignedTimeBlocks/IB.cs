namespace HM.HM3A.A.E.O.Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IB
    {
        ImmutableList<IBParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}