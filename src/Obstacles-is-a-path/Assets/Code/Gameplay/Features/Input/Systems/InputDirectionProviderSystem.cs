using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDirectionProviderSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly IGroup<GameEntity> _heroes;
    private readonly List<GameEntity> _buffer = new (1);

    public InputDirectionProviderSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.MovementDirection));
      
      _heroes = game.GetGroup(GameMatcher.Hero);
    }

    public void Execute()
    {
      foreach (GameEntity hero in _heroes.GetEntities(_buffer))
      foreach (GameEntity input in _inputs)
      {
        hero.ReplaceMovementDirection(input.MovementDirection);
      }
    }
  }
}