using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input
{
  [Game] public class Input : IComponent { }
  [Game] public class Interacted : IComponent { }
  
  [Game] public class InteractionPosition : IComponent { public Vector3 Value; }
}