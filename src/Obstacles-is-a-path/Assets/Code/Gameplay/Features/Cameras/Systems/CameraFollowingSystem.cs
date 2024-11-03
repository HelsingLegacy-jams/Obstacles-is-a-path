using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class CameraFollowingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _cameras;
    private readonly IGroup<GameEntity> _heroes;

    public CameraFollowingSystem(GameContext game)
    {
      _cameras = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.MainCamera,
          GameMatcher.Transform));

      _heroes = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Hero,
          GameMatcher.Transform));
    }

    public void Execute()
    {
      foreach (GameEntity hero in _heroes)
      foreach (GameEntity camera in _cameras)
      {
        Quaternion rotation = Quaternion.Euler(camera.RotationAngleX, 0, 0);
        Vector3 position = rotation * new Vector3(0, 0, -camera.Distance) + PositionOffset(hero, camera);

        camera.Transform.rotation = rotation;
        camera.Transform.position = position;
      }
    }

    private Vector3 PositionOffset(GameEntity hero, GameEntity camera)
    {
      Vector3 followingPosition = hero.Transform.position;
      followingPosition.y = camera.Offset;
      return followingPosition;
    }
  }
}