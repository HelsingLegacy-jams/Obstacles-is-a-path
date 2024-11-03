using Code.Infrastructure.Services.Scenes;
using Code.Infrastructure.StaticData;

namespace Code.Infrastructure.StateMachine.States
{
  public class BootstrapState : IState
  {
    private const string MainScene = "Main";
    private readonly ISceneLoader _sceneLoader;
    private readonly IGameStateMachine _stateMachine;
    private readonly IStaticDataServiceBinder _staticData;

    public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader, IStaticDataServiceBinder staticData)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
      _staticData = staticData;
    }

    public void Enter()
    {
      _staticData.BindStaticData();
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