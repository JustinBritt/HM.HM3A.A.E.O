namespace HM.HM3A.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments;

    public interface Iw
    {
        VariableCollection<IjIndexElement, IrIndexElement> Value { get; }

        bool GetElementAt(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement);

        Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments.Iw GetElementsAt(
            IwResultElementFactory wResultElementFactory,
            IwFactory wFactory,
            Ijr jr);
    }
}