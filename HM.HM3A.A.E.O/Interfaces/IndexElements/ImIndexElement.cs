namespace HM.HM3A.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface ImIndexElement
    {
        /// <summary>
        /// Gets the machine.
        /// </summary>
        Device Value { get; }
    }
}