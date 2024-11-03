using Code.Common.Entity;
using Code.Common.Extensions;
using Vector3 = UnityEngine.Vector3;

namespace Code.Gameplay.Features.Cameras.Factory
{
  public class CameraFactory : ICameraFactory
  {
    public GameEntity CreateMainCamera(Vector3 at)
    {
      return CreateEntity.Empty()
        .AddViewPath("Camera/Main Camera")
        .AddWorldPosition(at)
        .AddRotationAngleX(55)
        .AddDistance(18)
        .AddOffset(0.5f)
        .With(x => x.isMainCamera = true);
    }
  }
}