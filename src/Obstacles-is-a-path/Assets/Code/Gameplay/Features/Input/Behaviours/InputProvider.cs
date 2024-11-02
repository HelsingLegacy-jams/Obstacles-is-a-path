using Code.Common;
using Code.Common.Extensions;
using Code.Gameplay.Common.PhysicsService;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Code.Gameplay.Features.Input.Behaviours
{
  public class InputProvider : MonoBehaviour
  {
    private IPhysicsService _physics;

    [Inject]
    public void Construct(IPhysicsService physics) => 
      _physics = physics;

    public void OnMove(InputValue value)
    {
      var ray = Camera.main.ScreenPointToRay(value.Get<Vector2>());
      
      Vector3 position = _physics.Raycast(value.Get<Vector2>(), ray, CollisionLayers.Walkable.AsLayer());
      // _input.ResetMovementDirection(position);
      
      Debug.Log(position);
    }
  }
}