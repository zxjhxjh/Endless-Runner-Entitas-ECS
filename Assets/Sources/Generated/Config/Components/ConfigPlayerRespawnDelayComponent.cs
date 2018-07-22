//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity playerRespawnDelayEntity { get { return GetGroup(ConfigMatcher.PlayerRespawnDelay).GetSingleEntity(); } }
    public PlayerRespawnDelayComponent playerRespawnDelay { get { return playerRespawnDelayEntity.playerRespawnDelay; } }
    public bool hasPlayerRespawnDelay { get { return playerRespawnDelayEntity != null; } }

    public ConfigEntity SetPlayerRespawnDelay(float newValue) {
        if (hasPlayerRespawnDelay) {
            throw new Entitas.EntitasException("Could not set PlayerRespawnDelay!\n" + this + " already has an entity with PlayerRespawnDelayComponent!",
                "You should check if the context already has a playerRespawnDelayEntity before setting it or use context.ReplacePlayerRespawnDelay().");
        }
        var entity = CreateEntity();
        entity.AddPlayerRespawnDelay(newValue);
        return entity;
    }

    public void ReplacePlayerRespawnDelay(float newValue) {
        var entity = playerRespawnDelayEntity;
        if (entity == null) {
            entity = SetPlayerRespawnDelay(newValue);
        } else {
            entity.ReplacePlayerRespawnDelay(newValue);
        }
    }

    public void RemovePlayerRespawnDelay() {
        playerRespawnDelayEntity.Destroy();
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
public partial class ConfigEntity {

    public PlayerRespawnDelayComponent playerRespawnDelay { get { return (PlayerRespawnDelayComponent)GetComponent(ConfigComponentsLookup.PlayerRespawnDelay); } }
    public bool hasPlayerRespawnDelay { get { return HasComponent(ConfigComponentsLookup.PlayerRespawnDelay); } }

    public void AddPlayerRespawnDelay(float newValue) {
        var index = ConfigComponentsLookup.PlayerRespawnDelay;
        var component = CreateComponent<PlayerRespawnDelayComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerRespawnDelay(float newValue) {
        var index = ConfigComponentsLookup.PlayerRespawnDelay;
        var component = CreateComponent<PlayerRespawnDelayComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerRespawnDelay() {
        RemoveComponent(ConfigComponentsLookup.PlayerRespawnDelay);
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
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherPlayerRespawnDelay;

    public static Entitas.IMatcher<ConfigEntity> PlayerRespawnDelay {
        get {
            if (_matcherPlayerRespawnDelay == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.PlayerRespawnDelay);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherPlayerRespawnDelay = matcher;
            }

            return _matcherPlayerRespawnDelay;
        }
    }
}
