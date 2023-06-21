namespace HM.HM3A.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
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
            Ij j,
            Ir r)
        {
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> outerRedBlackTree = new RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>>();

            foreach (IjIndexElement jIndexElement in j.Value.Values)
            {
                RedBlackTree<IrIndexElement, IwResultElement> innerRedBlackTree = new RedBlackTree<IrIndexElement, IwResultElement>();

                foreach (IrIndexElement rIndexElement in r.Value.Values)
                {
                    innerRedBlackTree.Add(
                        rIndexElement,
                        wResultElementFactory.Create(
                            jIndexElement,
                            rIndexElement,
                            this.GetElementAt(
                                jIndexElement,
                                rIndexElement)));
                }

                outerRedBlackTree.Add(
                    jIndexElement,
                    innerRedBlackTree);
            }

            return wFactory.Create(
                outerRedBlackTree);
        }
    }
}