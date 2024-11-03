﻿using Code.Gameplay.Features.Hero.Systems;
using Code.Infrastructure.Factory;

namespace Code.Gameplay.Features.Hero
{
  public sealed class HeroFeature : Feature
  {
    public HeroFeature(ISystemFactory systems)
    {
      Add(systems.Create<InitHeroSystem>());
    }
  }
}