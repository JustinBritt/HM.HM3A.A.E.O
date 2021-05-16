﻿namespace HM.HM3A.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    public interface IObjectiveFactory
    {
        Objective Create(
            Expression expression,
            ObjectiveSense objectiveSense);
    }
}