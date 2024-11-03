﻿using Code.Gameplay.Features.Cameras.Systems;
using Code.Infrastructure.Factory;

namespace Code.Gameplay.Features.Cameras
{
  public sealed class CameraFeature : Feature
  {
    public CameraFeature(ISystemFactory systems)
    {
      Add(systems.Create<CameraInitializationSystem>());
      Add(systems.Create<CameraFollowingSystem>());
    }
  }
}