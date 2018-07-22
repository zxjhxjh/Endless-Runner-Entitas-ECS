//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity jumpFinishedEntity { get { return GetGroup(GameStateMatcher.JumpFinished).GetSingleEntity(); } }

    public bool isJumpFinished {
        get { return jumpFinishedEntity != null; }
        set {
            var entity = jumpFinishedEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isJumpFinished = true;
                } else {
                    entity.Destroy();
                }
            }
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
public partial class GameStateEntity {

    static readonly JumpFinishedComponent jumpFinishedComponent = new JumpFinishedComponent();

    public bool isJumpFinished {
        get { return HasComponent(GameStateComponentsLookup.JumpFinished); }
        set {
            if (value != isJumpFinished) {
                var index = GameStateComponentsLookup.JumpFinished;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : jumpFinishedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherJumpFinished;

    public static Entitas.IMatcher<GameStateEntity> JumpFinished {
        get {
            if (_matcherJumpFinished == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.JumpFinished);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherJumpFinished = matcher;
            }

            return _matcherJumpFinished;
        }
    }
}