using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputProviderSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;

    public InputProviderSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input));
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