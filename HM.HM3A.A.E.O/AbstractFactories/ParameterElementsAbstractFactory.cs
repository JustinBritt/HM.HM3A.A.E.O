namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.ParameterElements.DayAvailabilities;
    using HM.HM3A.A.E.O.Factories.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Factories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.Factories.ParameterElements.SurgicalSpecialties;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBParameterElementFactory CreateBBarParameterElementFactory()
        {
            HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBParameterElementFactory factory = null;

            try
            {
                factory = new HM.HM3A.A.E.O.Factories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.BParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks.IBParameterElementFactory CreateBsParameterElementFactory()
        {
            HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks.IBParameterElementFactory factory = null;

            try
            {
                factory = new HM.HM3A.A.E.O.Factories.ParameterElements.SurgeonNumberAssignedTimeBlocks.BParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ICParameterElementFactory CreateCParameterElementFactory()
        {
            ICParameterElementFactory factory = null;

            try
            {
                factory = new CParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΔParameterElementFactory CreateΔParameterElementFactory()
        {
            IΔParameterElementFactory factory = null;

            try
            {
                factory = new ΔParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IζParameterElementFactory CreateζParameterElementFactory()
        {
            IζParameterElementFactory factory = null;

            try
            {
                factory = new ζParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IψParameterElementFactory CreateψParameterElementFactory()
        {
            IψParameterElementFactory factory = null;

            try
            {
                factory = new ψParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}