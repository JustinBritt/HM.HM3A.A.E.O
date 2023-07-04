namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.Contexts;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IDayAvailabilitiesVisitorFactory CreateDayAvailabilitiesVisitorFactory()
        {
            IDayAvailabilitiesVisitorFactory factory = null;

            try
            {
                factory = new DayAvailabilitiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHM3AInputContextFactory CreateHM3AInputContextFactory()
        {
            IHM3AInputContextFactory factory = null;

            try
            {
                factory = new HM3AInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHM3AOutputContextFactory CreateHM3AOutputContextFactory()
        {
            IHM3AOutputContextFactory factory = null;

            try
            {
                factory = new HM3AOutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMachineCostsVisitorFactory CreateMachineCostsVisitorFactory()
        {
            IMachineCostsVisitorFactory factory = null;

            try
            {
                factory = new MachineCostsVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory()
        {
            IPlanningHorizonVisitorFactory factory = null;

            try
            {
                factory = new PlanningHorizonVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonMachineRequirementsOuterVisitorFactory CreateSurgeonMachineRequirementsOuterVisitorFactory()
        {
            ISurgeonMachineRequirementsOuterVisitorFactory factory = null;

            try
            {
                factory = new SurgeonMachineRequirementsOuterVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedTimeBlocksVisitorFactory CreateSurgeonNumberAssignedTimeBlocksVisitorFactory()
        {
            ISurgeonNumberAssignedTimeBlocksVisitorFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedTimeBlocksVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtiesVisitorFactory CreateSurgicalSpecialtiesVisitorFactory()
        {
            ISurgicalSpecialtiesVisitorFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory CreateSurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory()
        {
            ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory();
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