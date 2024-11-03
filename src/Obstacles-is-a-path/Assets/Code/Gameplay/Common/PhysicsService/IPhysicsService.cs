using UnityEngine;

namespace Code.Gameplay.Common.PhysicsService
{
  public interface IPhysicsService
  {
    Vector3 Raycast(Vector2 point, Ray ray, int layer);
  }
}