﻿using Code.Infrastructure.View;
using Entitas;

namespace Code.Common
{
  [Game] public class View : IComponent { public IEntityView Value; }
  [Game] public class ViewPath : IComponent { public IEntityView Value; }
  [Game] public class ViewPrefab : IComponent { public IEntityView Value; }
}