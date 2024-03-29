﻿namespace HM.HM3A.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Factories.Comparers;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;

    internal sealed class ComparersAbstractFactory : IComparersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ComparersAbstractFactory()
        {
        }

        public IDeviceComparerFactory CreateDeviceComparerFactory()
        {
            IDeviceComparerFactory factory = null;

            try
            {
                factory = new DeviceComparerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory()
        {
            IFhirDateTimeComparerFactory factory = null;

            try
            {
                factory = new FhirDateTimeComparerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILocationComparerFactory CreateLocationComparerFactory()
        {
            ILocationComparerFactory factory = null;

            try
            {
                factory = new LocationComparerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOrganizationComparerFactory CreateOrganizationComparerFactory()
        {
            IOrganizationComparerFactory factory = null;

            try
            {
                factory = new OrganizationComparerFactory();
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