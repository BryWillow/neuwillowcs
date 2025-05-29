namespace NeuWillow.Anatomy.Brain.Regions.Cerebrum.CerebralCortices.Hemispheres;

public interface ILeftCerebralHemisphere
{
  ILeftFrontalLobe FrontalLobe { get; }
  ILeftOccipitalLobe OccipitalLobe { get; }
  ILeftParietalLobe ParietalLobe { get; }
  ILeftTemporalLobe TemporalLobe { get; }
}