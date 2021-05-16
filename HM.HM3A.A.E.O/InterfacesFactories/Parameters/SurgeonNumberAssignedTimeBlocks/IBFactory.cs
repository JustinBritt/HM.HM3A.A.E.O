namespace HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;

    public interface IBFactory
    {
        IB Create(
            ImmutableList<IBParameterElement> value);
    }
}