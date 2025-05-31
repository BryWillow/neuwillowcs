namespace NeuWillow.Anatomy.Brain.Neurons.Dendrites;

public enum DendriteGatedIonChannelType
{
    None,
    VoltageGated,
    LigandGated
}

public interface IDendriteIonChannel
{
    DendriteGatedIonChannelType GatedIonChannelType { get; }
}

