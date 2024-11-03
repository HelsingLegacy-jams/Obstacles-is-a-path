using Entitas;

namespace Code.Gameplay.Features.Movement.Systems
{
  public class CharactersMovementSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _movers;

    public CharactersMovementSystem(GameContext game)
    {
      _movers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Moving,
          GameMatcher.MovementAvailable,
          GameMatcher.MovementDirection,
          GameMatcher.Speed,
          GameMatcher.CharacterMover));
    }

    public void Execute()
    {
      foreach (GameEntity mover in _movers)
      {
        mover.CharacterMover.MoveIn(mover.MovementDirection - mover.Transform.position, with: mover.Speed);
      }
    }
  }
}