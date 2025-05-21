namespace Neuron.AnatomyLib;

public interface ICerebralCortex
{
  ICerebralHemisphere LeftHemisphere { get; set; }
  ICerebralHemisphere RightHemisphere { get; set; }
}
