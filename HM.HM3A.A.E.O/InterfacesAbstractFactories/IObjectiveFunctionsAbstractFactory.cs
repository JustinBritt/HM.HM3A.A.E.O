namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.ObjectiveFunctions;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IObjectiveFunction001Factory CreateObjectiveFunction001Factory();

        IObjectiveFunction010Factory CreateObjectiveFunction010Factory();

        IObjectiveFunction100Factory CreateObjectiveFunction100Factory();
    }
}