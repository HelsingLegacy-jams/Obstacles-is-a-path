using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View.Factory
{
  public class EntityViewFactory : IEntityViewFactory
  {
    private readonly IInstantiator _instantiator;

    public EntityViewFactory(IInstantiator instantiator)
    {
      _instantiator = instantiator;
    }

    public EntityBehaviour CreateViewForEntity(GameEntity entity, Vector3 at)
    {
      EntityBehaviour viewPrefab = Resources.Load<EntityBehaviour>(entity.ViewPath);
      EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        viewPrefab,
        position: at,
        Quaternion.identity,
        parentTransform: null);

      view.SetEntity(entity);
      
      return view;
    }

    public EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity, Vector3 at)
    {
      EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        entity.ViewPrefab,
        position: at,
        Quaternion.identity,
        parentTransform: null);
      
      view.SetEntity(entity);

      return view;
    }
  }
}