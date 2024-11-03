using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.PhysicsService;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Input.Service;
using Code.Infrastructure.Common.Coroutines;
using Code.Infrastructure.Factory;
using Code.Infrastructure.Levels;
using Code.Infrastructure.Services.Scenes;
using Code.Infrastructure.StateMachine;
using Code.Infrastructure.StateMachine.States;
using Code.Infrastructure.StaticData;
using Code.Infrastructure.View.Factory;
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
      BindContexts();
      BindInstaller();
      BindCommonServices();
      BindFactories();
      BindGameStateMachine();
      BindGameplayServices();
    }

    private void BindGameplayServices()
    {
      Container.BindInterfacesTo<LevelDataProvider>().AsSingle();
    }

    private void BindContexts()
    {
      Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
      Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
    }

    private void BindCommonServices()
    {
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
      Container.Bind<IPhysicsService>().To<PhysicsService>().AsSingle();
      Container.Bind<IInputService>().To<InputService>().AsSingle();
      Container.BindInterfacesTo<StaticDataService>().AsSingle();
      Container.BindInterfacesTo<CollisionRegistry>().AsSingle();
    }

    private void BindInstaller()
    {
      Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
    }

    private void BindFactories()
    {
      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
      Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
      Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
      Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
    }

    private void BindGameStateMachine()
    {
      Container.BindInterfacesTo<GameStateMachine>().AsSingle();
    }
  }
}