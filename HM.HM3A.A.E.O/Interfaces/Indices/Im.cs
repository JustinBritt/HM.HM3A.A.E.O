namespace HM.HM3A.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface Im
    {
        ImmutableList<ImIndexElement> Value { get; }

        ImIndexElement GetElementAt(
            Device value);

        int GetM();
    }
}