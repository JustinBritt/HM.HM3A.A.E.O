namespace HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwResultElementFactory
    {
        IwResultElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            bool value);
    }
}