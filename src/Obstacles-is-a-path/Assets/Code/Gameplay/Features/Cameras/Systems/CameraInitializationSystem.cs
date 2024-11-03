using Code.Gameplay.Features.Cameras.Factory;
using Code.Gameplay.Features.Cameras.Provider;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class CameraInitializationSystem : IInitializeSystem
  {
    private readonly ICameraFactory _cameraFactory;
    private readonly ICameraProvider _cameraProvider;

    public CameraInitializationSystem(ICameraFactory cameraFactory, ICameraProvider cameraProvider)
    {
      _cameraFactory = cameraFactory;
      _cameraProvider = cameraProvider;
    }

    public void Initialize()
    {
      GameEntity mainCamera = _cameraFactory.CreateMainCamera(Vector3.zero);
      _cameraProvider.SetCamera(mainCamera);
    }
  }
}