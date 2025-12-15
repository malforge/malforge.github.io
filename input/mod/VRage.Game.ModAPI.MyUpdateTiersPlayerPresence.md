**Assembly:** VRage.Game.dll

```csharp
public enum MyUpdateTiersPlayerPresence
```

Describes tiers of player presence (if any player is nearby and grid is replicated to the client)

## Fields

|Member|Description|
|---|---|
|Normal|Player is nearby, grid is replicated to the client|
|Tier1|Player is not nearby, grid is not replicated to the client. Update time can be slower.|
|Tier2|Player is not nearby, grid is not replicated to the client. Update time can be even more slower.|

