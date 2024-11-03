using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras
{
  [Game] public class MainCamera : IComponent {}
  [Game] public class CameraComponent : IComponent { public Camera Value; }
}