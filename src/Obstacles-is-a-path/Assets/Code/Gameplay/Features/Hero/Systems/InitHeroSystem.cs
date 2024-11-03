using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Hero.Provider;
using Code.Infrastructure.Levels;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
  public class InitHeroSystem : IInitializeSystem
  {
    private readonly IHeroFactory _heroFactory;
    private readonly ILevelDataProvider _levelDataProvider;
    private readonly IHeroProvider _heroProvider;

    public InitHeroSystem(IHeroFactory heroFactory, ILevelDataProvider levelDataProvider, IHeroProvider heroProvider)
    {
      _heroFactory = heroFactory;
      _levelDataProvider = levelDataProvider;
      _heroProvider = heroProvider;
    }

    public void Initialize()
    {
      GameEntity hero = _heroFactory.CreateHero(_levelDataProvider.InitializationPoint);
      _heroProvider.SetHero(hero);
    }
  }
}