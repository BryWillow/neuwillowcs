namespace NeuWillow.Anatomy.Brain.Regions.Cerebrum.CerebralCortices.Hemispheres;

public class LeftCerebralHemisphere : ILeftCerebralHemisphere
{
  public LeftCerebralHemisphere(
    ILeftFrontalLobe frontalLobe,
    ILeftOccipitalLobe occipitalLobe,
    ILeftParietalLobe parietalLobe,
    ILeftTemporalLobe temporalLobe)
    {
      FrontalLobe = frontalLobe;
      OccipitalLobe = occipitalLobe;
      ParietalLobe = parietalLobe;
      TemporalLobe = temporalLobe;
    }

  public ILeftFrontalLobe FrontalLobe { get; private set; }
  public ILeftOccipitalLobe OccipitalLobe { get; private set; }
  public ILeftParietalLobe ParietalLobe { get; private set; }
  public ILeftTemporalLobe TemporalLobe { get; private set; }
}