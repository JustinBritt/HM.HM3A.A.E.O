namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.Parameters.DayAvailabilities;
    using HM.HM3A.A.E.O.Factories.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Factories.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.Factories.Parameters.SurgicalSpecialties;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory CreateBBarFactory()
        {
            HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory factory = null;

            try
            {
                factory = new HM.HM3A.A.E.O.Factories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks.IBFactory CreateBsFactory()
        {
            HM.HM3A.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks.IBFactory factory = null;

            try
            {
                factory = new HM.HM3A.A.E.O.Factories.Parameters.SurgeonNumberAssignedTimeBlocks.BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICFactory CreateCFactory()
        {
            ICFactory factory = null;

            try
            {
                factory = new CFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΔFactory CreateΔFactory()
        {
            IΔFactory factory = null;

            try
            {
                factory = new ΔFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IζFactory CreateζFactory()
        {
            IζFactory factory = null;

            try
            {
                factory = new ζFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IψFactory CreateψFactory()
        {
            IψFactory factory = null;

            try
            {
                factory = new ψFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}