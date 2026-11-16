**Assembly:** VRage.Game.dll

```csharp
public interface IMyToolbarChangeBuilder
```

Collects slot assignments for one set of toolbar slots and applies them together. Obtained from [BeginChanges()](VRage.Game.ModAPI.IMyToolbarSlots@BeginChanges) ; every method returns the same builder so calls can be chained, and nothing happens until [Apply()](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Apply) .

## Methods

|Member|Description|
|---|---|
|[Apply()](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Apply)|Applies the batch on the machine that owns these slots, and refuses anywhere else. A block toolbar is owned by the server, which applies the change and tells every client about it in a single message. A character toolbar is owned by its own player's machine, which applies it and lets it reach the session's saved copy from there.<br /><br />So a mod gets itself to the machine that owns the toolbar, by sending its own message, and calls this there. A slot the toolbar cannot hold is skipped and the rest still land, so a batch can apply in part. The builder is not consumed: keep it and apply it again to repeat the same batch.|
|[Clear(int)](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Clear)|Empties a slot.|
|[Set(int, MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Set)|Places an item in a slot, replacing whatever is there. This is what [TryGetItem(int, out MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarSlots@TryGetItem) returns, so a slot read from one toolbar can be placed in another as it stands. Any arguments the action takes are dropped; use the Set overload in Sandbox.ModAPI to carry them.|

