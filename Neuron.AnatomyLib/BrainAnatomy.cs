namespace Neuron.AnatomyLib;

using Neuron.CommonLib;


public class BrainAnatomy
    : Neuron.CommonLib.EnumClassBase Enumeration
{
  public static BrainAnatomy BrainStem = new(1, nameof(BrainStem));    
  
  public static BrainAnatomy Cerebellum = new(1, nameof(Cerebellum));

  public static BrainAnatomy FrontalLobe = new (1, nameof(FrontalLobe));

  public static BrainAnatomy OccipatalLobe = new(1, nameof(OccipatalLobe));

  public static BrainAnatomy ParietalLobe = new(1, nameof(ParietalLobe));

  public static BrainAnatomy TemporalLobe = new (1, nameof(TemporalLobe));

  public static BrainAnatomy SpinalCord = new(1, nameof(SpinalCord));

    public BrainAnatomy(int id, string name)
        : base(id, name)
    {
    }
}