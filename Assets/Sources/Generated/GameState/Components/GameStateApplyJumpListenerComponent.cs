//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public ApplyJumpListenerComponent applyJumpListener { get { return (ApplyJumpListenerComponent)GetComponent(GameStateComponentsLookup.ApplyJumpListener); } }
    public bool hasApplyJumpListener { get { return HasComponent(GameStateComponentsLookup.ApplyJumpListener); } }

    public void AddApplyJumpListener(System.Collections.Generic.List<IApplyJumpListener> newValue) {
        var index = GameStateComponentsLookup.ApplyJumpListener;
        var component = CreateComponent<ApplyJumpListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceApplyJumpListener(System.Collections.Generic.List<IApplyJumpListener> newValue) {
        var index = GameStateComponentsLookup.ApplyJumpListener;
        var component = CreateComponent<ApplyJumpListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveApplyJumpListener() {
        RemoveComponent(GameStateComponentsLookup.ApplyJumpListener);
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

    static Entitas.IMatcher<GameStateEntity> _matcherApplyJumpListener;

    public static Entitas.IMatcher<GameStateEntity> ApplyJumpListener {
        get {
            if (_matcherApplyJumpListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.ApplyJumpListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherApplyJumpListener = matcher;
            }

            return _matcherApplyJumpListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public void AddApplyJumpListener(IApplyJumpListener value) {
        var listeners = hasApplyJumpListener
            ? applyJumpListener.value
            : new System.Collections.Generic.List<IApplyJumpListener>();
        listeners.Add(value);
        ReplaceApplyJumpListener(listeners);
    }

    public void RemoveApplyJumpListener(IApplyJumpListener value, bool removeComponentWhenEmpty = true) {
        var listeners = applyJumpListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveApplyJumpListener();
        } else {
            ReplaceApplyJumpListener(listeners);
        }
    }
}
