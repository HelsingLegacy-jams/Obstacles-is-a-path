namespace Code.Infrastructure.StateMachine.States
{
  public class LoadLevelState : IState
  {
    private readonly IGameStateMachine _stateMachine;

    public LoadLevelState(IGameStateMachine stateMachine)
    {
      _stateMachine = stateMachine;
    }

    public void Enter()
    {
      _stateMachine.Enter<GameLoopState>();
    }

    public void Exit()
    {
    }
  }
}