using Cns.Anatomy.ConnectionPoints;

namespace Willow.Anatomy.Cns.Brain.Cerebrum.Hemisphere.Lobes.OccipitalLobe;

public interface OcciptalLobe : ICerebrumLobe
{
  public IConnectionPoint BrainStem { get; set; }
}
