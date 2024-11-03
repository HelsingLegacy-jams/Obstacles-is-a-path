using UnityEngine;

namespace Code.Gameplay.Features.Movement.Behaviours
{
  public class CharacterMover : MonoBehaviour
  {
    public CharacterController Controller;
    
    public void MoveIn(Vector3 direction, float with)
    {
      Vector3 moveDirection = direction;
      moveDirection.Normalize();

      moveDirection += Physics.gravity;
      
      Controller.Move(moveDirection * with * Time.deltaTime);
    }
  }
}