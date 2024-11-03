namespace Code.Infrastructure.View
{
  public interface IEntityComponentRegistrar
  {
    void RegisterComponent();
    void UnregisterComponent();
  }
}