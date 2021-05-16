namespace HM.HM3A.A.E.O.InterfacesFactories.Results.OverallWallTime
{
    using System;

    using HM.HM3A.A.E.O.Interfaces.Results.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}