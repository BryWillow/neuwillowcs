namespace Neuron.DendriteLib;

public interface IDendrite
{
  // Typically between 5-7.
  IEnumerable<IDendriteBranch> Branches { get; set; }
}