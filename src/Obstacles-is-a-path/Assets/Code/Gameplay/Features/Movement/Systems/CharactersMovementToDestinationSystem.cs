using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Systems
{
  public class CharactersMovementToDestinationSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _movers;
    private readonly List<GameEntity> _buffer = new (128);

    public CharactersMovementToDestinationSystem(GameContext game)
    {
      _movers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Moving,
          GameMatcher.MovementAvailable,
          GameMatcher.DestinationPosition,
          GameMatcher.Speed,
          GameMatcher.CharacterMover));
    }

    public void Execute()
    {
      foreach (GameEntity mover in _movers.GetEntities(_buffer))
      {
        if (Vector3.Distance(mover.Transform.position, mover.DestinationPosition) > 0.1f) 
          mover.CharacterMover.MoveIn(mover.DestinationPosition - mover.Transform.position, with: mover.Speed);
        else
          mover.RemoveDestinationPosition();
      }
    }
  }
}