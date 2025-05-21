namespace Neuron.NeurotransmitterLib;

public class NeuronCreationOptions
{
  NeurotransmitterType? NeurotransmitterType { get; set; }
}

public class NeuronFactory
{
  private readonly Dictionary<int, Domain.Neuron> _neuronIdToNeuron = new();

  public Domain.Neuron CreateNeuron(NeuronCreationOptions creationOptions)
  {
    return new Domain.Neuron();
  }
}