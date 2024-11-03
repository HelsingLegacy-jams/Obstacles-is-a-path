using Code.Gameplay.Features.Movement.Behaviours;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement
{
  [Game] public class Moving : IComponent {}
  [Game] public class MovementAvailable : IComponent {}
  
  [Game] public class Speed : IComponent { public float Value; }
  [Game] public class MovementDirection : IComponent { public Vector3 Value; }
  [Game] public class DestinationPosition : IComponent { public Vector3 Value; }
  
  [Game] public class CharacterMoverComponent : IComponent { public CharacterMover Value; }
}