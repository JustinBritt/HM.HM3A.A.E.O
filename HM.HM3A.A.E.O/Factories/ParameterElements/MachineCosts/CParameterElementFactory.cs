namespace HM.HM3A.A.E.O.Factories.ParameterElements.MachineCosts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Classes.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts;

    internal sealed class CParameterElementFactory : ICParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CParameterElementFactory()
        {
        }

        public ICParameterElement Create(
            ImIndexElement mIndexElement,
            Money value)
        {
            ICParameterElement parameterElement = null;

            try
            {
                parameterElement = new CParameterElement(
                    mIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}