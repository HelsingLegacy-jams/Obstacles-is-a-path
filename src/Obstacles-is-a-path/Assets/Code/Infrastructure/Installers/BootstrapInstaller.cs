using Code.Infrastructure.Common.Coroutines;
using Code.Infrastructure.StateMachine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize()
    {
      
    }

    public override void InstallBindings()
    {
      BindFactories();
      BindGameStateMachine();
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