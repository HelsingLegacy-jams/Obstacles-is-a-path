using UnityEngine;

namespace Code.Infrastructure.Levels
{
  public interface ILevelDataBinder
  {
    void BindHeroInitializationPoint(Vector3 initialPoint);
  }
}