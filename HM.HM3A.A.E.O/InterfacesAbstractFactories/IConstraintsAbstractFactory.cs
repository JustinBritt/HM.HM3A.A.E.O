namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.Constraints;

    public interface IConstraintsAbstractFactory
    {
        IConstraints1Factory CreateConstraints1Factory();

        IConstraints2Factory CreateConstraints2Factory();

        IConstraints3Factory CreateConstraints3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraints5LFactory CreateConstraints5LFactory();

        IConstraints5MFactory CreateConstraints5MFactory();

        IConstraints5UFactory CreateConstraints5UFactory();
    }
}