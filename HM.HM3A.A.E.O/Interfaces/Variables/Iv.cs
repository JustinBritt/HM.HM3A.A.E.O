namespace HM.HM3A.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments;

    public interface Iv
    {
        VariableCollection<ImIndexElement, IrIndexElement> Value { get; }

        bool GetElementAt(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement);

        Interfaces.Results.MachineOperatingRoomAssignments.Iv GetElementsAt(
            IvResultElementFactory vResultElementFactory,
            IvFactory vFactory,
            Imr mr);
    }
}