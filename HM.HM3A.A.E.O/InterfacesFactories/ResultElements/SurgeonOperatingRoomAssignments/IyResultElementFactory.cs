namespace HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;

    public interface IyResultElementFactory
    {
        IyResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            bool value);
    }
}