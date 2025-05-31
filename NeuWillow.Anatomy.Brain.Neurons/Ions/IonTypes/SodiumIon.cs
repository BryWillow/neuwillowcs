namespace NeuWillow.Anatomy.Brain.Neurons.Ions;

/// <summary>
/// Encapsulaptes the properties of a Sodium Ion.
/// </summary>
public class SodiumIon : IIon
{
    // In Columb Units: +1.602 × 10⁻¹⁹, or 1.
    public int ElementaryCharge => 1;

    // A Potassium Ion has 1 unit remoted from a neutral Potassium Atom.
    public IonType Type => IonType.Cation;
}