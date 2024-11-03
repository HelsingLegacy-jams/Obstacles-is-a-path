namespace Code.Gameplay.Features.Cameras.Provider
{
  public interface ICameraProvider
  {
    GameEntity Main { get; }
    void SetCamera(GameEntity camera);
  }
}