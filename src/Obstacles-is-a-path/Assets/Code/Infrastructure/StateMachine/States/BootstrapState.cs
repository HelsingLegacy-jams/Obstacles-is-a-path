using Code.Infrastructure.Services.Scenes;

namespace Code.Infrastructure.StateMachine.States
{
  public class BootstrapState : IState
  {
    private const string MainScene = "Main";
    private readonly ISceneLoader _sceneLoader;
    private readonly IGameStateMachine _stateMachine;

    public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
    }

    public void Enter()
    {
      _sceneLoader.Load(MainScene, MoveToNextState);
    }

    private void MoveToNextState()
    {
      _stateMachine.Enter<LoadLevelState>();
    }

    public void Exit()
    {
    }
  }
}