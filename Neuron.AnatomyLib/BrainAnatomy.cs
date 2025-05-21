namespace Neuron.AnatomyLib;


public class BrainAnatomy
    : Neuron.CommonLib.EnumClassBase
{
    public static BrainAnatomy Invalid = new(0, nameof(Invalid));
    public static BrainAnatomy BrainStem = new(1, nameof(BrainStem));
    public static BrainAnatomy Cerebellum = new(2, nameof(Cerebellum));
    public static BrainAnatomy FrontalLobe = new(3, nameof(FrontalLobe));
    public static BrainAnatomy OccipatalLobe = new(4, nameof(OccipatalLobe));
    public static BrainAnatomy ParietalLobe = new(5, nameof(ParietalLobe));
    public static BrainAnatomy TemporalLobe = new(6, nameof(TemporalLobe));
    public static BrainAnatomy SpinalCord = new(7, nameof(SpinalCord));

    public BrainAnatomy(int id, string name)
        : base(id, name)
    {
    }
}