namespace NeuWillow.Anatomy.Brain.Neurons.Ions;

public enum IonGateType
{
    Invalid,
    LigandGated,
    VoltageGated
}

public enum IonType
{
    Invalid,
    Anion,
    Cation
}

public interface IIon
{
    // See Columb Units for more details.
    int ElementaryCharge { get; }
    IonType Type { get; }
}