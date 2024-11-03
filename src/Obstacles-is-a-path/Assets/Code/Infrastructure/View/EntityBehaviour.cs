﻿using Code.Gameplay.Common.Collisions;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
  public class EntityBehaviour : MonoBehaviour, IEntityView
  {
    private GameEntity _entity;
    private ICollisionRegistry _collisionRegistry;

    public GameEntity Entity => _entity;

    [Inject]
    public void Construct(ICollisionRegistry collisionRegistry) => 
      _collisionRegistry = collisionRegistry;

    public void SetEntity(GameEntity entity)
    {
      _entity = entity;
      _entity.AddView(this);
      _entity.Retain(this);

      foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>()) 
        registrar.RegisterComponent();
      
      foreach (Collider collider in GetComponentsInChildren<Collider>(includeInactive: true)) 
        _collisionRegistry.Register(collider.GetInstanceID(), _entity);
    }

    public void ReleaseEntity()
    {
      foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>()) 
        registrar.UnregisterComponent();
      
      foreach (Collider collider in GetComponentsInChildren<Collider>(includeInactive: true)) 
        _collisionRegistry.Unregister(collider.GetInstanceID());

      _entity.Release(this);
      _entity = null;
    }
  }
}