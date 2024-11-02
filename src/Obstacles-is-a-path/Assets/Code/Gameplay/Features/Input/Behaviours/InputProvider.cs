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
    // private ICameraService _camera;

    private Vector3 _lastPosition;

    [Inject]
    public void Construct(IPhysicsService physics, IInputService inputService)
    {
      _physics = physics;
      _input = inputService;
      // _camera = camera;
    }

    public void OnMove(InputValue value)
    {
      Vector2 pointerPosition = value.Get<Vector2>();

      if (pointerPosition == Vector2.zero)
      {
        _input.Entity.AddDestinationPosition(_lastPosition);
        _input.Entity.RemoveMovementDirection();
        return;
      }

      _lastPosition = RaycastPosition(pointerPosition);

      _input.Entity.ReplaceMovementDirection(_lastPosition);
    }

    private Vector3 RaycastPosition(Vector2 pointerPosition)
    {
      Ray ray = Camera.main.ScreenPointToRay(pointerPosition);

      Vector3 position = _physics.Raycast(pointerPosition, ray, CollisionLayers.Walkable.AsLayer());
      return position;
    }
  }
}