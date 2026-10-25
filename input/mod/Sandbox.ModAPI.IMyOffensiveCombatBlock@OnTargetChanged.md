## Summary

```csharp
public Action<IMyOffensiveCombatBlock, IMyEntity, IMyEntity, bool> event OnTargetChanged
```

Triggers when target was changed First entity is old target Second entity is new target Bool - when true, it is called from recent search, when false it is called when entity was destroyed

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4?view=netframework-4.6)&lt;[IMyOffensiveCombatBlock](Sandbox.ModAPI.IMyOffensiveCombatBlock), [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity), [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt;

