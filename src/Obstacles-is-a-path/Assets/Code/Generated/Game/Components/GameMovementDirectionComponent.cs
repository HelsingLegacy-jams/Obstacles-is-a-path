//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMovementDirection;

    public static Entitas.IMatcher<GameEntity> MovementDirection {
        get {
            if (_matcherMovementDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MovementDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovementDirection = matcher;
            }

            return _matcherMovementDirection;
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

    public Code.Gameplay.Features.Movement.MovementDirection movementDirection { get { return (Code.Gameplay.Features.Movement.MovementDirection)GetComponent(GameComponentsLookup.MovementDirection); } }
    public UnityEngine.Vector3 MovementDirection { get { return movementDirection.Value; } }
    public bool hasMovementDirection { get { return HasComponent(GameComponentsLookup.MovementDirection); } }

    public GameEntity AddMovementDirection(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.MovementDirection;
        var component = (Code.Gameplay.Features.Movement.MovementDirection)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.MovementDirection));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceMovementDirection(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.MovementDirection;
        var component = (Code.Gameplay.Features.Movement.MovementDirection)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.MovementDirection));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveMovementDirection() {
        RemoveComponent(GameComponentsLookup.MovementDirection);
        return this;
    }
}
