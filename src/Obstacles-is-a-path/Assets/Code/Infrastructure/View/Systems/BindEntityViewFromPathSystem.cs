﻿using System.Collections.Generic;
using Code.Infrastructure.View.Factory;
using Entitas;

namespace Code.Infrastructure.View.Systems
{
  public class BindEntityViewFromPathSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _entities;
    private readonly IEntityViewFactory _entityFactory;
    private readonly List<GameEntity> _buffer = new (32);

    public BindEntityViewFromPathSystem(GameContext game, IEntityViewFactory entityFactory)
    {
      _entityFactory = entityFactory;
      
      _entities = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ViewPath,
          GameMatcher.WorldPosition)
        .NoneOf(GameMatcher.View));
    }

    public void Execute()
    {
      foreach (GameEntity entity in _entities.GetEntities(_buffer))
      {
        _entityFactory.CreateViewForEntity(entity, entity.WorldPosition);
      }
    }
  }
}