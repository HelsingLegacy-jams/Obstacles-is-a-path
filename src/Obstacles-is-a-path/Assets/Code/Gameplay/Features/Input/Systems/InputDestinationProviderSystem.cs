using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDestinationProviderSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly List<GameEntity> _buffer = new (1);

    public InputDestinationProviderSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.DestinationPosition));
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs.GetEntities(_buffer))
      {
        Debug.Log("Destination position is: " + input.DestinationPosition);
      }
    }
  }
}