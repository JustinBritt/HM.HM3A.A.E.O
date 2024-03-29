﻿namespace HM.HM3A.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3A.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonMachineRequirementsInnerVisitor<TKey, TValue> : ISurgeonMachineRequirementsInnerVisitor<TKey, TValue>
        where TKey : Device
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMachineRequirementsInnerVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IζParameterElementFactory ζParameterElementFactory,
            IsIndexElement sIndexElement,
            Im m)
        {
            this.ζParameterElementFactory = ζParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.m = m;

            this.RedBlackTree = redBlackTreeFactory.Create<ImIndexElement, IζParameterElement>();
        }

        private IζParameterElementFactory ζParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Im m { get; }

        public bool HasCompleted => false;

        public RedBlackTree<ImIndexElement, IζParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ImIndexElement mIndexElement = this.m.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                mIndexElement,
                this.ζParameterElementFactory.Create(
                    this.sIndexElement,
                    mIndexElement,
                    obj.Value));
        }
    }
}