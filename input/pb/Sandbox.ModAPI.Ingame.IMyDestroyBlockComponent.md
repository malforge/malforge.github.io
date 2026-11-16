**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyDestroyBlockComponent
```

Entity component that cleanly detaches (removes) its block from the grid and triggers the block's saved toolbar actions. Ingame scripting interface.

## Methods

|Member|Description|
|---|---|
|[Detach()](Sandbox.ModAPI.Ingame.IMyDestroyBlockComponent@Detach)|Triggers the block's toolbar actions, plays the custom detach sound and particle effect, and removes the block from its grid. The block is removed, not destroyed, so no default destruction effects are played. Server-authoritative.|

