namespace HM.HM3A.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints1ConstraintElementFactory : IConstraints1ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElementFactory()
        {
        }

        public IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Iζ ζ,
            Iv v,
            Iy y)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    mIndexElement,
                    rIndexElement,
                    m,
                    s,
                    ζ,
                    v,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}