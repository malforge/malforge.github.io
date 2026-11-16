## Summary

```csharp
public IMyToolbar CurrentToolbar { get; }
```

Gets the toolbar this player is driving at the moment: their character toolbar, or the controlled block's while they are seated, following the same switches the HUD does. This is local state rather than session state, so it is null for every player except the one running the code, and null on a dedicated server.

## Returns

[IMyToolbar](VRage.Game.ModAPI.IMyToolbar)

