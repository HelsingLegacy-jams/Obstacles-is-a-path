using Code.Gameplay.Features.Input;
using Code.Infrastructure.Factory;
using Code.Infrastructure.View.Systems;

namespace Code.Gameplay.Features
{
  public class BattleFeature : Feature
  {
    public BattleFeature(ISystemFactory systems)
    {
      Add(systems.Create<BindViewFeature>());
      
      Add(systems.Create<InputFeature>());
    }
  }
}