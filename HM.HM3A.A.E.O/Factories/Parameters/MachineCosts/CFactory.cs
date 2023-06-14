namespace HM.HM3A.A.E.O.Factories.Parameters.MachineCosts
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Classes.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.Interfaces.Parameters.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.Parameters.MachineCosts;

    internal sealed class CFactory : ICFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CFactory()
        {
        }

        public IC Create(
            RedBlackTree<ImIndexElement, ICParameterElement> value)
        {
            IC parameter = null;

            try
            {
                parameter = new C(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}