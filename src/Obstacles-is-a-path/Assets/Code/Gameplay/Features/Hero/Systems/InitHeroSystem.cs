using Code.Gameplay.Features.Hero.Factory;
using Code.Infrastructure.Levels;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
  public class InitHeroSystem : IInitializeSystem
  {
    private readonly IHeroFactory _heroFactory;
    private readonly ILevelDataProvider _levelDataProvider;

    public InitHeroSystem(IHeroFactory heroFactory, ILevelDataProvider levelDataProvider)
    {
      _heroFactory = heroFactory;
      _levelDataProvider = levelDataProvider;
    }

    public void Initialize()
    {
      _heroFactory.CreateHero(_levelDataProvider.InitializationPoint);
    }
  }
}