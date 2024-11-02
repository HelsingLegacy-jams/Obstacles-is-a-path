using UnityEngine;

namespace Code.Infrastructure.StateMachine.States
{
  public class GameLoopState : IState
  {
    public void Enter()
    {
      Debug.Log("Loop State Entered.");
    }

    public void Exit()
    {
    }
  }
}