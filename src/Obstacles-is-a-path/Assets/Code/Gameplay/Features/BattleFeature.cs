using Code.Gameplay.Features.Input;
using Code.Infrastructure.Factory;

namespace Code.Gameplay.Features
{
  public class BattleFeature : Feature
  {
    public BattleFeature(ISystemFactory systems)
    {
      Add(systems.Create<InputFeature>());
    }
  }
}