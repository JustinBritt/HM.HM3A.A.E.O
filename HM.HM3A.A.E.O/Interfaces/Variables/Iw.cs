﻿namespace HM.HM3A.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;

    public interface Iw
    {
        VariableCollection<IjIndexElement, IrIndexElement> Value { get; }

        bool GetElementAt(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement);

        Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments.Iw GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IwResultElementFactory wResultElementFactory,
            IwFactory wFactory,
            Ij j,
            Ir r);
    }
}