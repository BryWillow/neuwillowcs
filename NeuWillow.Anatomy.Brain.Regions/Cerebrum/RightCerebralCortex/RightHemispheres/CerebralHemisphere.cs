namespace NeuWillow.Anatomy.Brain.Regions.Cerebrum.Hemisphere;

public class CerebralHemisphere : ICerebralHemisphere
{
  public ICerebrumLobe FrontalLobe { get; set; }
  public ICerebrumLobe OccipitalLobe { get; set; }
  public ICerebrumLobe ParietalLobe { get; set; }
  public ICerebrumLobe TemporalLobe { get; set; }
}
