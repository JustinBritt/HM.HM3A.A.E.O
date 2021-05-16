namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory();

        IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory();

        IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory();

        IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory();

        IConstraints5LConstraintElementFactory CreateConstraints5LConstraintElementFactory();

        IConstraints5MConstraintElementFactory CreateConstraints5MConstraintElementFactory();

        IConstraints5UConstraintElementFactory CreateConstraints5UConstraintElementFactory();
    }
}