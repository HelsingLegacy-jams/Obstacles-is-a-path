using System.Collections.Generic;
using Code.Gameplay.Common.Collisions;
using UnityEngine;

namespace Code.Gameplay.Common.PhysicsService
{
  public class PhysicsService : IPhysicsService
  {
    private static readonly Collider[] OverlapHits = new Collider[32];
    
    private readonly ICollisionRegistryEntity _collisionRegistry;
    private IPhysicsService _physicsServiceImplementation;

    public PhysicsService(ICollisionRegistryEntity collisionRegistry)
    {
      _collisionRegistry = collisionRegistry;
    }

    public Vector3 Raycast(Ray ray, int layer) =>
      Physics.Raycast(ray, out RaycastHit hit, 40, layer)
        ? hit.point
        : Vector3.zero;

    public IEnumerable<GameEntity> SphereCast(Vector3 position, float radius, int layerMask)
    {
      int hitCount = OverlapSphere(position, radius, OverlapHits, layerMask);

      for (int i = 0; i < hitCount; i++)
      {
        GameEntity entity = _collisionRegistry.Get<GameEntity>(OverlapHits[i].GetInstanceID());
        
        if (entity == null)
          continue;
        
        yield return entity;
      }
    }

    private int OverlapSphere(Vector3 worldPosition, float radius, Collider[] hits, int layerMask) => 
      UnityEngine.Physics.OverlapSphereNonAlloc(worldPosition, radius, hits, layerMask);
  }
}