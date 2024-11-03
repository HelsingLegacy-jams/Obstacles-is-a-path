namespace Code.Gameplay.Common.Collisions
{
  public interface ICollisionRegistryEntity
  {
    TEntity Get<TEntity>(int instanceId) where TEntity : class;
  }
}