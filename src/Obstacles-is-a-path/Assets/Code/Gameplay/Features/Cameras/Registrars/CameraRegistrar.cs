using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Registrars
{
  public class CameraRegistrar : EntityComponentRegistrar
  {
    public Camera Camera;
    
    public override void RegisterComponent() => 
      Entity.AddCamera(Camera);

    public override void UnregisterComponent()
    {
      if (Entity.hasCamera)
        Entity.RemoveCamera();
    }
  }
}