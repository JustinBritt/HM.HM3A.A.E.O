namespace HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    public interface IB
    {
        ImmutableList<IBParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}