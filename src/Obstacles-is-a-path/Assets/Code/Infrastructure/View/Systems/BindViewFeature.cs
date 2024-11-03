using Code.Infrastructure.Factory;

namespace Code.Infrastructure.View.Systems
{
  public sealed class BindViewFeature : Feature
  {
    public BindViewFeature(ISystemFactory systems)
    {
      Add(systems.Create<BindEntityViewFromPathSystem>());
      Add(systems.Create<BindEntityViewFromPrefabSystem>());
    }
  }
}