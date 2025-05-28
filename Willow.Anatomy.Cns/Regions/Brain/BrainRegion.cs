namespace Willow.Anatomy.Cns;

public class BrainRegion
    : Willow.Anatomy.Cns.CommonLib.EnumClassBase
{
    public static BrainRegion Invalid = new(0, nameof(Invalid));
    public static BrainRegion BrainStem = new(1, nameof(BrainStem));
    public static BrainRegion Cerebellum = new(2, nameof(Cerebellum));
    public static BrainRegion FrontalLobe = new(3, nameof(FrontalLobe));
    public static BrainRegion OccipatalLobe = new(4, nameof(OccipatalLobe));
    public static BrainRegion ParietalLobe = new(5, nameof(ParietalLobe));
    public static BrainRegion TemporalLobe = new(6, nameof(TemporalLobe));
    public static BrainRegion SpinalCord = new(7, nameof(SpinalCord));

    public BrainRegion(int id, string name)
        : base(id, name)
    {
    }
}