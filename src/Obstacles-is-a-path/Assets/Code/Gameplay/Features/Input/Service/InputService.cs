using Code.Common.Entity;
using Code.Common.Extensions;

namespace Code.Gameplay.Features.Input.Service
{
  public class InputService : IInputService
  {
    public GameEntity Entity { get; private set; }

    public void BindInputEntity()
    {
      Entity = 
        CreateEntity
          .Empty()
          .With(x=>x.isInput = true);
    }
  }
}