## Summary

```csharp
public IMyToolbar Toolbar { get; }
```

Gets this player's character toolbar, or null when the session holds none for them. This is the copy the session owns and saves, which is a separate object from the live toolbar the local player's HUD draws; edits reach it through a client to server update. See [CurrentToolbar](VRage.Game.ModAPI.IMyPlayer@CurrentToolbar) for the live one.

## Returns

[IMyToolbar](VRage.Game.ModAPI.IMyToolbar)

