using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement
{
  [Game] public class Moving : IComponent {}
  [Game] public class MovementAvailable : IComponent {}
  
  [Game] public class MovementDirection : IComponent { public Vector3 Value; }
  [Game] public class DestinationPosition : IComponent { public Vector3 Value; }
}