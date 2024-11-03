using Code.Gameplay.Features.Input.Service;

namespace Code.Infrastructure.StateMachine.States
{
  public class LoadLevelState : IState
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly IInputService _input;

    public LoadLevelState(IGameStateMachine stateMachine, IInputService input)
    {
      _stateMachine = stateMachine;
      _input = input;
    }

    public void Enter()
    {
      _input.BindInputEntity();
      _stateMachine.Enter<GameLoopState>();
    }

    public void Exit()
    {
    }
  }
}