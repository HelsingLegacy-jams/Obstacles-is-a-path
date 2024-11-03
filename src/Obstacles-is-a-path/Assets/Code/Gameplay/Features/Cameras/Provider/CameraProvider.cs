namespace Code.Gameplay.Features.Cameras.Provider
{
  public class CameraProvider : ICameraProvider
  {
    public GameEntity Main { get; private set; }

    public void SetCamera(GameEntity camera) => 
      Main = camera;
  }
}