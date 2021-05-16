namespace HM.HM3A.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Variables;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            VariableCollection<IjIndexElement, IrIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IjIndexElement, IrIndexElement> Value { get; }

        public bool GetElementAt(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement)
        {
            bool value = false;

            if (this.Value[jIndexElement, rIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments.Iw GetElementsAt(
            IwResultElementFactory wResultElementFactory,
            IwFactory wFactory,
            Ijr jr)
        {
            return wFactory.Create(
                jr.Value
                .Select(
                    i => wResultElementFactory.Create(
                        i.jIndexElement,
                        i.rIndexElement,
                        this.GetElementAt(
                            i.jIndexElement,
                            i.rIndexElement)))
                .ToImmutableList());
        }
    }
}