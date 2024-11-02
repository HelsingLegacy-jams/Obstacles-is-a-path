using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDestinationCleaningSystem : ICleanupSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly List<GameEntity> _buffer = new (1);

    public InputDestinationCleaningSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input, 
          GameMatcher.DestinationPosition));
    }

    public void Cleanup()
    {
      foreach (GameEntity input in _inputs.GetEntities(_buffer))
      {
        input.RemoveDestinationPosition();
      }
    }
  }
}