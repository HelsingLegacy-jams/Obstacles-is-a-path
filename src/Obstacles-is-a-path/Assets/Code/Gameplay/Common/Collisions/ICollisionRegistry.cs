using Entitas;

namespace Code.Gameplay.Common.Collisions
{
  public interface ICollisionRegistry
  {
    void Register(int instanceId, IEntity entity);
    void Unregister(int instanceId);
  }
}