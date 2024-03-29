﻿namespace HM.HM3A.A.E.O.Factories.Comparers
{
    using HM.HM3A.A.E.O.Classes.Comparers;
    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;

    internal sealed class DeviceComparerFactory : IDeviceComparerFactory
    {
        public DeviceComparerFactory()
        {
        }

        public IDeviceComparer Create()
        {
            IDeviceComparer instance = null;

            try
            {
                instance = new DeviceComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}