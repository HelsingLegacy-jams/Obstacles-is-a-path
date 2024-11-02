using UnityEngine;

namespace Code.Gameplay.Common.PhysicsService
{
  public class PhysicsService : IPhysicsService
  {
    public Vector3 Raycast(Vector2 point, Ray ray, int layer)
    {
      return Physics.Raycast(ray, out RaycastHit hit, 20, layer) 
        ? hit.point 
        : Vector3.zero;
    }
  }
}