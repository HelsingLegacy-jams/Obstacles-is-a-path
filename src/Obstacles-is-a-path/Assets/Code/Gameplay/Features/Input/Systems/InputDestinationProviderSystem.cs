using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDestinationProviderSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly IGroup<GameEntity> _heroes;
    private readonly List<GameEntity> _buffer = new (1);

    public InputDestinationProviderSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.DestinationPosition));

      _heroes = game.GetGroup(GameMatcher.Hero);
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      foreach (GameEntity hero in _heroes.GetEntities(_buffer))
      {
        hero.AddDestinationPosition(input.DestinationPosition);

        if (hero.hasMovementDirection)
          hero.RemoveMovementDirection();
      }
    }
  }
}