using System.Reflection;

namespace Neuron.NeurotransmitterLib;

public class EffectType
    : EffectTypeEnum
{
  public static EffectType Invalid = new(0, nameof(Invalid));
  public static EffectType Inhibitory = new(1, nameof(Inhibitory));
  public static EffectType Excitatory = new(2, nameof(Excitatory));
  public static EffectType Modulatory = new(3, nameof(Modulatory));
  public static EffectType InhibitoryAndExcitatory = new(4, nameof(InhibitoryAndExcitatory));

  public EffectType(int id, string name) : base(id, name)
  {
  }  
}

// Note: this code was written by Microsoft, or at least came from their website:
// https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
// Admittedly, I don't fully understand the BindingFlags.
// TODO: Become more familiar with the Enumeration class.
public abstract class EffectTypeEnum : IComparable
{
  public EffectType EffectType { get; set; }

  public string Name { get; set; }

  public int Id { get; set; }

  protected EffectTypeEnum(int id, string name) => (Id, Name) = (id, name);

  public override string ToString() => Name;

  public static IEnumerable<T> GetAll<T>() where T : EffectTypeEnum =>
      typeof(T).GetFields(BindingFlags.Public |
                          BindingFlags.Static |
                          BindingFlags.DeclaredOnly)
               .Select(f => f.GetValue(null))
               .Cast<T>();

  public override bool Equals(object obj)
  {
    if (obj is not EffectTypeEnum otherValue)
    {
      return false;
    }

    var typeMatches = GetType().Equals(obj.GetType());
    var valueMatches = Id.Equals(otherValue.Id);

    return typeMatches && valueMatches;
  }

  public int CompareTo(object other) => Id.CompareTo(((EffectTypeEnum)other).Id);

  public override int GetHashCode()
  {
    throw new NotImplementedException();
  }

  // Other utility methods ...
}