﻿using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputInteractionCleaningSystem : ICleanupSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly List<GameEntity> _buffer = new (1);

    public InputInteractionCleaningSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input, 
          GameMatcher.Interacted, 
          GameMatcher.InteractionPosition));
    }

    public void Cleanup()
    {
      foreach (GameEntity input in _inputs.GetEntities(_buffer))
      {
        input.RemoveInteractionPosition();
        input.isInteracted = false;
      }
    }
  }
}