using Cns.Anatomy.ConnectionPoints;

namespace Cns.Anatomy.SpinalCord;

public interface ISpinalCord
{
  // This should live in a derived class.
  // For now, it's here so othat I remember.
  const int VertabraeCount = 26;

  IProtectiveMembrane LayerOne { get; set; }
  IProtectiveMembrane LayerTwo { get; set; }
  IProtectiveMembrane LayerThree { get; set; }
  IContinuationPoint BrainStem { get; set; }
  IConnectionPoint OccipitalLobe { get; set; }
}