//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDistance;

    public static Entitas.IMatcher<GameEntity> Distance {
        get {
            if (_matcherDistance == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Distance);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDistance = matcher;
            }

            return _matcherDistance;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.Cameras.Distance distance { get { return (Code.Gameplay.Features.Cameras.Distance)GetComponent(GameComponentsLookup.Distance); } }
    public float Distance { get { return distance.Value; } }
    public bool hasDistance { get { return HasComponent(GameComponentsLookup.Distance); } }

    public GameEntity AddDistance(float newValue) {
        var index = GameComponentsLookup.Distance;
        var component = (Code.Gameplay.Features.Cameras.Distance)CreateComponent(index, typeof(Code.Gameplay.Features.Cameras.Distance));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceDistance(float newValue) {
        var index = GameComponentsLookup.Distance;
        var component = (Code.Gameplay.Features.Cameras.Distance)CreateComponent(index, typeof(Code.Gameplay.Features.Cameras.Distance));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveDistance() {
        RemoveComponent(GameComponentsLookup.Distance);
        return this;
    }
}