namespace Code.Gameplay.Features.Hero.Provider
{
  public class HeroProvider : IHeroProvider
  {
    public GameEntity Hero { get; private set; }

    public void SetHero(GameEntity hero) => 
      Hero = hero;
  }
}