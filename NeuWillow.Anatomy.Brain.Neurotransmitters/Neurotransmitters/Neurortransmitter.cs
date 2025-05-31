namespace NeuWillow.Anatomy.Brain.Neurotransmitters;

/// <summary>
/// All neurotransmitters have a few properties in common:
/// 1. They are synthesized and stored in the neuron.
/// 2. 
/// </summary>
public class Neurotransmitter
{
  private Neurotransmitter() { }

  public Neurotransmitter Create(NeurotransmitterType neurotransmitterType)
  {
    if (neurotransmitterType == NeurotransmitterType.Invalid)
      throw new ArgumentException("Attempt to create a Neurotransmitter with an invalid type");

    return new Neurotransmitter();
  }

  public NeurotransmitterType Type { get; }
}