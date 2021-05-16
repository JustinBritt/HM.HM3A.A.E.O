namespace HM.HM3A.A.E.O.Factories.Solutions
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Solutions;
    using HM.HM3A.A.E.O.Interfaces.Solutions;
    using HM.HM3A.A.E.O.InterfacesFactories.Solutions;

    internal sealed class HM3ASolutionFactory : IHM3ASolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3ASolutionFactory()
        {
        }

        public IHM3ASolution Create()
        {
            IHM3ASolution solution = null;

            try
            {
                solution = new HM3ASolution();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return solution;
        }
    }
}