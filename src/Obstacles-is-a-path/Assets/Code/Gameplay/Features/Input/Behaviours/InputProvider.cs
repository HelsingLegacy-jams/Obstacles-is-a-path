using Code.Common;
using Code.Common.Extensions;
using Code.Gameplay.Common.PhysicsService;
using Code.Gameplay.Features.Input.Service;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Code.Gameplay.Features.Input.Behaviours
{
  public class InputProvider : MonoBehaviour
  {
    private IPhysicsService _physics;
    private IInputService _input;

    [Inject]
    public void Construct(IPhysicsService physics, IInputService inputService)
    {
      _physics = physics;
      _input = inputService;
    }

    public void OnMove(InputValue value)
    {
      var ray = Camera.main.ScreenPointToRay(value.Get<Vector2>());
      
      Vector3 position = _physics.Raycast(value.Get<Vector2>(), ray, CollisionLayers.Walkable.AsLayer());
      _input.Entity.ReplaceMovementDirection(position);
    }
  }
}