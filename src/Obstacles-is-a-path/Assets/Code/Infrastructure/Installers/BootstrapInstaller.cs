using Code.Infrastructure.Common.Coroutines;
using Code.Infrastructure.Services.Scenes;
using Code.Infrastructure.StateMachine;
using Code.Infrastructure.StateMachine.States;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize()
    {
      Container.Resolve<IStatesBinder>().BindStates();
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    public override void InstallBindings()
    {
      BindInstaller();
      BindCommonServices();
      BindFactories();
      BindGameStateMachine();
    }

    private void BindCommonServices()
    {
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
    }

    private void BindInstaller()
    {
      Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
    }

    private void BindFactories()
    {
      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
    }

    private void BindGameStateMachine()
    {
      Container.BindInterfacesTo<GameStateMachine>().AsSingle();
    }
  }
}