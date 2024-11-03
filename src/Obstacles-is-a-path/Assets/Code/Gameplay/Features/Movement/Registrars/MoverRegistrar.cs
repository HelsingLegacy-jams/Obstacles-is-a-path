using Code.Gameplay.Features.Movement.Behaviours;
using Code.Infrastructure.View;
using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Features.Movement.Registrars
{
  public class MoverRegistrar : EntityComponentRegistrar
  {
    public CharacterMover Mover;
    
    public override void RegisterComponent() => 
      Entity.AddCharacterMover(Mover);

    public override void UnregisterComponent()
    {
      if (Entity.hasCharacterMover)
        Entity.RemoveCharacterMover();
    }
  }
}