using Entitas;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class CameraFollowingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _cameras;

    public CameraFollowingSystem(GameContext game)
    {
      _cameras = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.MainCamera));
    }

    public void Execute()
    {
      foreach (GameEntity camera in _cameras)
      {
        
      }
    }
  }
}