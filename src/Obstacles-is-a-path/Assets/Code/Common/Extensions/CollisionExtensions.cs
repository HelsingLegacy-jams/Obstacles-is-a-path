using Code.Gameplay.Common.Collisions;

namespace Code.Common.Extensions
{
  public static class CollisionExtensions
  {
    public static int AsLayer(this CollisionLayers layer) => 
      1 << (int)layer;
  }
}