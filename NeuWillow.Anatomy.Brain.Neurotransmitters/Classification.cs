using System.Reflection;

namespace NeuWillow.Anatomy.Brain.Neurotransmitters;

public class Classification
    : ClassificationEnum
{
  public static Classification Invalid = new(0, nameof(Invalid));
  public static Classification SmallMolecule = new(1, nameof(SmallMolecule));
  public static Classification AminoAcid = new(2, nameof(AminoAcid));
  public static Classification NeuroactivePeptide = new(3, nameof(NeuroactivePeptide));
  public static Classification SoluableGas = new(4, nameof(SoluableGas));

  public Classification(int id, string name) : base(id, name)
  {
  }
}

// Note: this code was written by Microsoft, or at least came from their website:
// https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
// Admittedly, I don't fully understand the BindingFlags.
// TODO: Become more familiar with the Enumeration class.
public abstract class ClassificationEnum : IComparable
{
  public Classification Classification { get; set; }

  public string Name { get; set; }

  public int Id { get; set; }

  protected ClassificationEnum(int id, string name) => (Id, Name) = (id, name);

  public override string ToString() => Name;

  public static IEnumerable<T> GetAll<T>() where T : ClassificationEnum =>
      typeof(T).GetFields(BindingFlags.Public |
                          BindingFlags.Static |
                          BindingFlags.DeclaredOnly)
               .Select(f => f.GetValue(null))
               .Cast<T>();

  public override bool Equals(object obj)
  {
    if (obj is not ClassificationEnum otherValue)
    {
      return false;
    }

    var typeMatches = GetType().Equals(obj.GetType());
    var valueMatches = Id.Equals(otherValue.Id);

    return typeMatches && valueMatches;
  }

  public int CompareTo(object other) => Id.CompareTo(((ClassificationEnum)other).Id);

  public override int GetHashCode()
  {
    throw new NotImplementedException();
  }

  // Other utility methods ...
}