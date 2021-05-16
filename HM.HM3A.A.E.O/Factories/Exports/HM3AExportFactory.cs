namespace HM.HM3A.A.E.O.Factories.Exports
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Exports;
    using HM.HM3A.A.E.O.Interfaces.Exports;
    using HM.HM3A.A.E.O.InterfacesFactories.Exports;

    internal sealed class HM3AExportFactory : IHM3AExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AExportFactory()
        {
        }

        public IHM3AExport Create()
        {
            IHM3AExport export = null;

            try
            {
                export = new HM3AExport();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return export;
        }
    }
}