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
  // Function: Memory, arousal, attention, motivation.
  public static NeurotransmitterType Acetylcholine = new (1, nameof(Acetylcholine));

  // Function: Pain, inflammation.
  public static NeurotransmitterType Atp = new (1, nameof(Atp));

  // Function: Fight-or-Flight. A.K.A., Adrenaline.
  public static NeurotransmitterType Epinephrine = new(1, nameof(Epinephrine));

  // Function: Pleasure.
  public static NeurotransmitterType Dopamine = new(1, nameof(Dopamine));

  // Function: Euphoria.
  public static NeurotransmitterType Endorphins = new(1, nameof(Endorphins));

  // Function: Calming.
  public static NeurotransmitterType Gaba = new(1, nameof(Gaba));

  // Function: Memory.
  public static NeurotransmitterType Glutamate = new(1, nameof(Glutamate));

  // Function: Calming, Inihibitory, secondary to GABA.
  public static NeurotransmitterType Glycine = new(1, nameof(Glycine));

  // Function: Wakefulness, Alertness.
  public static NeurotransmitterType Histamine = new(1, nameof(Histamine));

  // Function: Mood, Arousal, Vigilance, Memory.
  public static NeurotransmitterType Norepinephrine = new(1, nameof(Norepinephrine));

  // Function: Social bonding.
  public static NeurotransmitterType Oxytocin = new(1, nameof(Oxytocin));

  // Function: Mood.
  public static NeurotransmitterType Serotonin = new(1, nameof(Serotonin));

    public NeurotransmitterType(int id, string name)
        : base(id, name)
    {
    }
}