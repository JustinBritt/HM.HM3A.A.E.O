﻿namespace HM.HM3A.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IbFactory
    {
        Ib Create(
            VariableCollection<IsIndexElement, IrIndexElement> value);
    }
}