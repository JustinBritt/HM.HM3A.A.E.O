namespace HM.HM3A.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Classes.Indices;
    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Indices;
    
    internal sealed class rFactory : IrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rFactory()
        {
        }

        public Ir Create(
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer,
            ImmutableList<IrIndexElement> value)
        {
            Ir index = null;

            try
            {
                index = new r(
                    this.CreateRedBlackTree(
                        redBlackTreeFactory,
                        locationComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<Location, IrIndexElement> CreateRedBlackTree(
            IRedBlackTreeFactory redBlackTreeFactory,
            ILocationComparer locationComparer,
            ImmutableList<IrIndexElement> value)
        {
            RedBlackTree<Location, IrIndexElement> redBlackTree = redBlackTreeFactory.Create<Location, IrIndexElement>(
                locationComparer);

            foreach (IrIndexElement rIndexElement in value)
            {
                redBlackTree.Add(
                    rIndexElement.Value,
                    rIndexElement);
            }

            return redBlackTree;
        }
    }
}