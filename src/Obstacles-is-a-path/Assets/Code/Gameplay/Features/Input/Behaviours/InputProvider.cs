using Code.Common;
using Code.Common.Extensions;
using Code.Gameplay.Common.Collisions;
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

    private Vector3 _lastMovementPosition;
    private Vector3 _lastInteractionPosition;

    [Inject]
    public void Construct(IPhysicsService physics, IInputService inputService)
    {
      _physics = physics;
      _input = inputService;
      // _camera = camera;
    }

    public void OnInteraction(InputValue value)
    {
      if (value.Get<Vector2>() == Vector2.zero)
      {
        _input.Entity.isInteracted = true;
        _input.Entity.ReplaceInteractionPosition(_lastInteractionPosition);
        return;
      }
      
      _lastInteractionPosition = RaycastPosition(value.Get<Vector2>(), CollisionLayers.Interactable);
    }

    public void OnMove(InputValue value)
    {
      if (value.Get<Vector2>() == Vector2.zero)
      {
        _input.Entity.AddDestinationPosition(_lastMovementPosition);
        _input.Entity.RemoveMovementDirection();
        return;
      }

      _lastMovementPosition = RaycastPosition(value.Get<Vector2>(), CollisionLayers.Walkable);

      _input.Entity.ReplaceMovementDirection(_lastMovementPosition);
    }

    private Vector3 RaycastPosition(Vector2 pointerPosition, CollisionLayers layer)
    {
      Ray ray = Camera.main.ScreenPointToRay(pointerPosition);

      Vector3 position = _physics.Raycast(pointerPosition, ray, layer.AsLayer());
      return position;
    }
  }
}