using UnityEngine;

namespace Code.Infrastructure.Levels
{
  public class LevelDataProvider : ILevelDataProvider, ILevelDataBinder
  {
    public Vector3 InitializationPoint { get; private set; }

    public void BindHeroInitializationPoint(Vector3 initialPoint) =>
      InitializationPoint = initialPoint;
  }
}