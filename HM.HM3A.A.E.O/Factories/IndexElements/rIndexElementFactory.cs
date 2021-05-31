﻿namespace HM.HM3A.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Classes.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class rIndexElementFactory : IrIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rIndexElementFactory()
        {
        }

        public IrIndexElement Create(
            Location value)
        {
            IrIndexElement indexElement = null;

            try
            {
                indexElement = new rIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}