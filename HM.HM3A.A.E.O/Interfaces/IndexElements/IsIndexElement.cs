namespace HM.HM3A.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IsIndexElement
    {
        /// <summary>
        /// Gets the surgeon.
        /// </summary>
        Organization Value { get; }
    }
}