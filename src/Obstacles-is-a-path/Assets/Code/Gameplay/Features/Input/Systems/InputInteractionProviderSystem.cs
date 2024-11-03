using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputInteractionProviderSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;

    public InputInteractionProviderSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input, 
          GameMatcher.Interacted, 
          GameMatcher.InteractionPosition));
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      {
        Debug.Log("Interaction position point is: " +input.InteractionPosition);
      }
    }
  }
}