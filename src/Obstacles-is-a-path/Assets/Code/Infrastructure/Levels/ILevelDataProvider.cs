using UnityEngine;

namespace Code.Infrastructure.Levels
{
  public interface ILevelDataProvider
  {
    Vector3 InitializationPoint { get; }
  }
}