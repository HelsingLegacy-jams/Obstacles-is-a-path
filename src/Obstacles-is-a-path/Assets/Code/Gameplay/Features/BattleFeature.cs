﻿using Code.Gameplay.Features.Cameras;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Input;
using Code.Gameplay.Features.Movement;
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
      Add(systems.Create<HeroFeature>());
      
      Add(systems.Create<MovementFeature>());
      
      Add(systems.Create<CameraFeature>());
    }
  }
}