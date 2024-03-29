﻿namespace HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;

    public interface IBFactory
    {
        IB Create(
            RedBlackTree<IsIndexElement, IBParameterElement> value);
    }
}