using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Factory
{
  public class HeroFactory : IHeroFactory
  {
    public GameEntity CreateHero(Vector3 at)
    {
      return CreateEntity.Empty()
        .AddViewPath("Hero/Hero")
        .AddWorldPosition(at)
        .AddSpeed(5)
        .With(x => x.isHero = true)
        .With(x => x.isMovementAvailable = true);
    }
  }
}