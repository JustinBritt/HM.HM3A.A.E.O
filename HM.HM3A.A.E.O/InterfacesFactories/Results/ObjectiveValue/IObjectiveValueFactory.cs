namespace HM.HM3A.A.E.O.InterfacesFactories.Results.ObjectiveValue
{
    using HM.HM3A.A.E.O.Interfaces.Results.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}