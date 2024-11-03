using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDirectionProviderSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;

    public InputDirectionProviderSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.MovementDirection));
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      {
        Debug.Log(input.MovementDirection);
      }
    }
  }
}