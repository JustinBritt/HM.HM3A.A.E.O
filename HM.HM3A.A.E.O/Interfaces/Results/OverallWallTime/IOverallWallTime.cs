namespace HM.HM3A.A.E.O.Interfaces.Results.OverallWallTime
{
    using System;

    public interface IOverallWallTime
    {
        TimeSpan Value { get; }

        TimeSpan GetValueForOutputContext();
    }
}