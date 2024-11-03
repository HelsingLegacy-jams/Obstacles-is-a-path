using UnityEngine;

namespace Code.Gameplay.Features.Movement.Behaviours
{
  public class CharacterMover : MonoBehaviour
  {
    public CharacterController Controller;
    
    public void MoveIn(Vector3 direction) => 
      Controller.Move(direction);
  }
}