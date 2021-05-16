namespace HM.HM3A.A.E.O.Interfaces.Models
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3A.A.E.O.Interfaces.CrossJoins;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3A.A.E.O.Interfaces.Variables;

    public interface IHM3AModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Ij j { get; }

        Is s { get; }

        Ijr jr { get; }

        Imr mr { get; }

        Isr sr { get; }

        IΔ Δ { get; }

        Iv v { get; }

        Iw w { get; }

        Iy y { get; }
    }
}