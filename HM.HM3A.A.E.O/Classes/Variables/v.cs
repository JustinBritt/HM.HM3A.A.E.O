namespace HM.HM3A.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            VariableCollection<ImIndexElement, IrIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<ImIndexElement, IrIndexElement> Value { get; }

        public bool GetElementAt(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement)
        {
            bool value = false;

            if (this.Value[mIndexElement, rIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.MachineOperatingRoomAssignments.Iv GetElementsAt(
            IvResultElementFactory vResultElementFactory,
            IvFactory vFactory,
            Imr mr)
        {
            return vFactory.Create(
                mr.Value
                .Select(
                    i => vResultElementFactory.Create(
                        i.mIndexElement,
                        i.rIndexElement,
                        this.GetElementAt(
                            i.mIndexElement,
                            i.rIndexElement)))
                .ToImmutableList());
        }
    }
}