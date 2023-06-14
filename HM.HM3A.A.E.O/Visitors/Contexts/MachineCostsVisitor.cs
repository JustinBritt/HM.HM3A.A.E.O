namespace HM.HM3A.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.MachineCosts;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class MachineCostsVisitor<TKey, TValue> : IMachineCostsVisitor<TKey, TValue>
        where TKey : Device
        where TValue : Money
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MachineCostsVisitor(
            ICParameterElementFactory CParameterElementFactory,
            Im m)
        {
            this.CParameterElementFactory = CParameterElementFactory;

            this.m = m;

            this.RedBlackTree = new RedBlackTree<ImIndexElement, ICParameterElement>();
        }

        private ICParameterElementFactory CParameterElementFactory { get; }

        private Im m { get; }

        public bool HasCompleted => false;

        public RedBlackTree<ImIndexElement, ICParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ImIndexElement mIndexElement = this.m.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                mIndexElement,
                this.CParameterElementFactory.Create(
                    mIndexElement,
                    obj.Value));
        }
    }
}