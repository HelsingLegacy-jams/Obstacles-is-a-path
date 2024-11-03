//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherViewPath;

    public static Entitas.IMatcher<GameEntity> ViewPath {
        get {
            if (_matcherViewPath == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ViewPath);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherViewPath = matcher;
            }

            return _matcherViewPath;
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

    public Code.Common.ViewPath viewPath { get { return (Code.Common.ViewPath)GetComponent(GameComponentsLookup.ViewPath); } }
    public Code.Infrastructure.View.IEntityView ViewPath { get { return viewPath.Value; } }
    public bool hasViewPath { get { return HasComponent(GameComponentsLookup.ViewPath); } }

    public GameEntity AddViewPath(Code.Infrastructure.View.IEntityView newValue) {
        var index = GameComponentsLookup.ViewPath;
        var component = (Code.Common.ViewPath)CreateComponent(index, typeof(Code.Common.ViewPath));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceViewPath(Code.Infrastructure.View.IEntityView newValue) {
        var index = GameComponentsLookup.ViewPath;
        var component = (Code.Common.ViewPath)CreateComponent(index, typeof(Code.Common.ViewPath));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveViewPath() {
        RemoveComponent(GameComponentsLookup.ViewPath);
        return this;
    }
}
