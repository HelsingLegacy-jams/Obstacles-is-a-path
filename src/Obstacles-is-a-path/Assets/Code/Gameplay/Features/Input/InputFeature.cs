﻿using Code.Gameplay.Features.Input.Systems;
using Code.Infrastructure.Factory;

namespace Code.Gameplay.Features.Input
{
  public sealed class InputFeature : Feature
  {
    public InputFeature(ISystemFactory systems)
    {
      Add(systems.Create<InputProviderSystem>());
      Add(systems.Create<InputDestinationProviderSystem>());
      
      Add(systems.Create<InputDestinationCleaningSystem>());
    }
  }
}