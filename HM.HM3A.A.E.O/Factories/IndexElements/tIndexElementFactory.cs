﻿namespace HM.HM3A.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Classes.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class tIndexElementFactory : ItIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tIndexElementFactory()
        {
        }

        public ItIndexElement Create(
            int key,
            FhirDateTime value)
        {
            ItIndexElement indexElement = null;

            try
            {
                indexElement = new tIndexElement(
                    key,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return indexElement;
        }
    }
}