namespace Neuron.NeurotransmitterLib;

using Neuron.CommonLib;

/// <summary>
/// TODO: A lot of work here:
/// (1) This is not a comprehensive list of neurotransmitters.
/// (2) Classify these neurotransmitters into Small-Molecule Receptors (e.g. Glutamate)
///     and Neuropeptides (insulin and its impact).
/// (3) Neurotransmitters are multi-faceted, e.g., Gaba might be Calming and other things.
/// (4) Where are specific types of neurotransmitters produced in higher concentrations.
/// </summary>
public class NeurotransmitterType
    : Enumeration
{
    // Fight-or-Flight.
    public static NeurotransmitterType Adrenaline = new(3, nameof(Adrenaline));

    // Pleasure.
    public static NeurotransmitterType Dopamine = new(1, nameof(Dopamine));

    // Euphoria.
    public static NeurotransmitterType Endorphins = new(1, nameof(Endorphins));

    // Calming.
    public static NeurotransmitterType Gaba = new(2, nameof(Gaba));

    // Memory.
    public static NeurotransmitterType Glutamate = new(2, nameof(Glutamate));

    //Mood.
    public static NeurotransmitterType Serotonin = new(3, nameof(Serotonin));

    public NeurotransmitterType(int id, string name)
        : base(id, name)
    {
    }
}