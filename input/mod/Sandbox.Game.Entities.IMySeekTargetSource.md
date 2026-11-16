**Assembly:** Sandbox.Game.dll

```csharp
public interface IMySeekTargetSource
```

A weapon that can tell a guided missile what to home on, so the shot can resolve a target without knowing whether it was fired from a block on a grid or from a hand weapon.

## Methods

|Member|Description|
|---|---|
|[GetSeekTargetEntityId(MyEntity)](Sandbox.Game.Entities.IMySeekTargetSource@GetSeekTargetEntityId)|Resolves the entity id a guided (CanSeek) missile fired now should home on; 0 means dumb-fire.|

