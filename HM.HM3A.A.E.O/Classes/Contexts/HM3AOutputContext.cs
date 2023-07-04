namespace HM.HM3A.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Enums;
    using HM.HM3A.A.E.O.InterfacesAbstractFactories;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.Interfaces.Models;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;

    internal sealed class HM3AOutputContext : IHM3AOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM3AModel HM3AModel,
            Solution solution,
            HM3AEncodingEnum HM3AEncodingEnum)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // v(m, r)
            this.MachineOperatingRoomAssignments = HM3AModel.v.GetElementsAt(
                resultElementsAbstractFactory.CreatevResultElementFactory(),
                resultsAbstractFactory.CreatevFactory(),
                HM3AModel.m,
                HM3AModel.r)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                HM3AModel.m,
                HM3AModel.r);

            // w(j, r)
            this.SurgicalSpecialtyOperatingRoomAssignments = HM3AModel.w.GetElementsAt(
                resultElementsAbstractFactory.CreatewResultElementFactory(),
                resultsAbstractFactory.CreatewFactory(),
                HM3AModel.j,
                HM3AModel.r)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());           

            // y(s, r)
            Iy y = HM3AModel.y.GetElementsAt(
                resultElementsAbstractFactory.CreateyResultElementFactory(),
                resultsAbstractFactory.CreateyFactory(),
                HM3AModel.r,
                HM3AModel.s);

            this.SurgeonOperatingRoomAssignments = y
            .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonNumberAssignedOperatingRooms
            this.SurgeonNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsFactory(),
                calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                HM3AModel.s,
                y)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgicalSpecialtyNumberAssignedOperatingRooms
            this.SurgicalSpecialtyNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory(),
                resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory(),
                calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                HM3AModel.Δ,
                y)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedOperatingRooms { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> MachineOperatingRoomAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgicalSpecialtyOperatingRoomAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }
    }
}