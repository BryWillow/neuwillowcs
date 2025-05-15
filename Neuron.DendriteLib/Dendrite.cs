namespace Neuron.DendriteLib;

  public class Dendrite : IDendrite
  {
    public IEnumerable<IDendriteBranch> Branches { get; set; }
  }
