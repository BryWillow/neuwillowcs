namespace NeuWillow.Anatomy.Brain.Regions.Cerebrum
{
  /// <summary>
  /// 1. Largest surface area of the brain.
  /// 2. Consists of 4 lobes.
  /// 3. Controls Executive Function, Judgment, and Decision Making.
  /// </summary>
  public interface ICerebrum
  {
    ILeftCerebralHemisphere LeftBrain { get; set; }
    IRightCerebralHemisphere RightBrain { get; set; }
  }
}
