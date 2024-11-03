//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int View = 0;
    public const int ViewPath = 1;
    public const int ViewPrefab = 2;
    public const int Input = 3;
    public const int Interacted = 4;
    public const int InteractionPosition = 5;
    public const int DestinationPosition = 6;
    public const int MovementAvailable = 7;
    public const int MovementDirection = 8;
    public const int Moving = 9;

    public const int TotalComponents = 10;

    public static readonly string[] componentNames = {
        "View",
        "ViewPath",
        "ViewPrefab",
        "Input",
        "Interacted",
        "InteractionPosition",
        "DestinationPosition",
        "MovementAvailable",
        "MovementDirection",
        "Moving"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Code.Common.View),
        typeof(Code.Common.ViewPath),
        typeof(Code.Common.ViewPrefab),
        typeof(Code.Gameplay.Features.Input.Input),
        typeof(Code.Gameplay.Features.Input.Interacted),
        typeof(Code.Gameplay.Features.Input.InteractionPosition),
        typeof(Code.Gameplay.Features.Movement.DestinationPosition),
        typeof(Code.Gameplay.Features.Movement.MovementAvailable),
        typeof(Code.Gameplay.Features.Movement.MovementDirection),
        typeof(Code.Gameplay.Features.Movement.Moving)
    };
}
