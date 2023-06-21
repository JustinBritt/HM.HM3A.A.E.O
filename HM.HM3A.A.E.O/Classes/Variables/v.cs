namespace HM.HM3A.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
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
            Im m,
            Ir r)
        {
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> outerRedBlackTree = new RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>>();

            foreach (ImIndexElement mIndexElement in m.Value.Values)
            {
                RedBlackTree<IrIndexElement, IvResultElement> innerRedBlackTree = new RedBlackTree<IrIndexElement, IvResultElement>();

                foreach (IrIndexElement rIndexElement in r.Value.Values)
                {
                    innerRedBlackTree.Add(
                        rIndexElement,
                        vResultElementFactory.Create(
                            mIndexElement,
                            rIndexElement,
                            this.GetElementAt(
                                mIndexElement,
                                rIndexElement)));
                }

                outerRedBlackTree.Add(
                    mIndexElement,
                    innerRedBlackTree);
            }

            return vFactory.Create(
                outerRedBlackTree);
        }
    }
}