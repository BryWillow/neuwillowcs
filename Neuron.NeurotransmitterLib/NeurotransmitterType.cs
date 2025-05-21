namespace Neuron.NeurotransmitterLib;

using System.Reflection;

/// <summary>
/// TODO: A lot of work here:
/// (1) This is not a comprehensive list of neurotransmitters.
/// (2) What regions in the brain can neurotransmitters have different effect types?
/// (3) What is the root cause of why neurotransmitters can have different effect types?
/// </summary>
public class NeurotransmitterType
    : NeurotransmitterTypeEnum
{
    public static NeurotransmitterType Invalid = new(0, Classification.Invalid, EffectType.Invalid, string.Empty);
    // Function: Memory, arousal, attention, motivation.
    public static NeurotransmitterType Acetylcholine = new(1, Classification.SmallMolecule, EffectType.Excitatory, nameof(Acetylcholine));

    // Function: Pain, inflammation. AKA, ATP.
    public static NeurotransmitterType AdenosineTriphosphate = new(2, Classification.SmallMolecule, EffectType.InhibitoryAndExcitatory, nameof(AdenosineTriphosphate));

    // Function: Fight-or-Flight. AKA, Adrenaline.
    public static NeurotransmitterType Epinephrine = new(3, Classification.SmallMolecule, EffectType.InhibitoryAndExcitatory, nameof(Epinephrine));

    // Function: Pleasure.
    public static NeurotransmitterType Dopamine = new(4, Classification.SmallMolecule, EffectType.InhibitoryAndExcitatory, nameof(Dopamine));

    // Function: Euphoria.
    public static NeurotransmitterType Endorphins = new(5, Classification.SmallMolecule, EffectType.Inhibitory, nameof(Endorphins));

    // Function: Calming.
    public static NeurotransmitterType Gaba = new(6, Classification.AminoAcid, EffectType.InhibitoryAndExcitatory, nameof(Gaba));

    // Function: Memory.
    public static NeurotransmitterType Glutamate = new(7, Classification.SmallMolecule, EffectType.Excitatory, nameof(Glutamate));

    // Function: Calming, Inihibitory, secondary to GABA.
    public static NeurotransmitterType Glycine = new(7, Classification.AminoAcid, EffectType.Inhibitory, nameof(Glycine));

    // Function: Wakefulness, Alertness.
    public static NeurotransmitterType Histamine = new(8, Classification.SmallMolecule, EffectType.InhibitoryAndExcitatory, nameof(Histamine));

    // Function: Mood, Arousal, Vigilance, Memory.
    public static NeurotransmitterType Norepinephrine = new(9, Classification.SmallMolecule, EffectType.InhibitoryAndExcitatory, nameof(Norepinephrine));

    // Function: Social bonding.
    public static NeurotransmitterType Oxytocin = new(10, Classification.NeuroactivePeptide, EffectType.InhibitoryAndExcitatory, nameof(Oxytocin));

    // Function: Mood.
    public static NeurotransmitterType Serotonin = new(11, Classification.SmallMolecule, EffectType.Inhibitory, nameof(Serotonin));

    public NeurotransmitterType(int id, Classification classification, EffectType effectType, string name)
        : base(id, classification, effectType, name)
    {
    }
}

// Note: this code was written by Microsoft, or at least came from their website:
// https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
// Admittedly, I don't fully understand the BindingFlags.
// TODO: Become more familiar with the Enumeration class.
public abstract class NeurotransmitterTypeEnum : IComparable
{
    public int Id { get; set; }

    public string Name { get; set; }

    public EffectType EffectType { get; set; }

    public Classification Classification { get; set; }

    protected NeurotransmitterTypeEnum(int id, Classification classification, EffectType effectType, string name) =>
        (Id, Classification, EffectType, Name) = (id, classification, effectType, name);

    public override string ToString() => Name;

    public static IEnumerable<T> GetAll<T>() where T : NeurotransmitterTypeEnum =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();

    public override bool Equals(object obj)
    {
        if (obj is not NeurotransmitterTypeEnum otherValue)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = Id.Equals(otherValue.Id);

        return typeMatches && valueMatches;
    }

    public int CompareTo(object other) => Id.CompareTo(((NeurotransmitterTypeEnum)other).Id);

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    // Other utility methods ...}
}