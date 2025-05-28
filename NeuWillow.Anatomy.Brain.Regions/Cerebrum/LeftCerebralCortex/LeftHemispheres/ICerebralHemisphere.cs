namespace NeuWillow.Anatomy.Brain.Regions.Cerebrum.Hemisphere.Lobes;

public interface ICerebralHemisphere
{
  ICerebrumLobe FrontalLobe { get; set; }
  ICerebrumLobe OccipitalLobe { get; set; }
  ICerebrumLobe ParietalLobe { get; set; }
  ICerebrumLobe TemporalLobe { get; set; }
}