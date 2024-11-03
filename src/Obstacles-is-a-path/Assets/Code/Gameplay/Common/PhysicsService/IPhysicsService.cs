using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Common.PhysicsService
{
  public interface IPhysicsService
  {
    Vector3 Raycast(Vector2 point, Ray ray, int layer);
    IEnumerable<GameEntity> SphereCast(Vector3 position, float radius, int layerMask);
  }
}