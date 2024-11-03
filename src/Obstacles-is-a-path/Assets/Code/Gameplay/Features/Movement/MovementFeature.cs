﻿using Code.Gameplay.Features.Movement.Systems;
using Code.Infrastructure.Factory;

namespace Code.Gameplay.Features.Movement
{
  public sealed class MovementFeature : Feature
  {
    public MovementFeature(ISystemFactory systems)
    {
      Add(systems.Create<CharactersMovementSystem>());
      Add(systems.Create<CharactersMovementToDestinationSystem>());
    }
  }
}