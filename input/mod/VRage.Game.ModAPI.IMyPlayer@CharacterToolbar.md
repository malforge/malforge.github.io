## Summary

```csharp
public IMyToolbar CharacterToolbar { get; }
```

Gets the live character toolbar this machine draws for the player, the one their hotbar shows on foot. This is the character toolbar that accepts writes; [Toolbar](VRage.Game.ModAPI.IMyPlayer@Toolbar) is the session's saved copy and is read only. Null for every player except the one running the code, and null on a dedicated server.

## Returns

[IMyToolbar](VRage.Game.ModAPI.IMyToolbar)

