using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Factory
{
  public interface ICameraFactory
  {
    GameEntity CreateMainCamera(Vector3 at);
  }
}