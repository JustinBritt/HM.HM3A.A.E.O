namespace HM.HM3A.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IrIndexElement : IComparable<IrIndexElement>
    {
        /// <summary>
        /// Gets the operating room.
        /// </summary>
        Location Value { get; }
    }
}