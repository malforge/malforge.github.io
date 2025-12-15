## Summary

```csharp
public Action<IMyOffensiveCombatBlock, IMyEntity, IMyEntity, bool> event OnTargetChanged
```

Triggers when target was changed First entity is old target Second entity is new target Bool - when true, it is called from recent search, when false it is called when entity was destroyed

## Returns

[Action<IMyOffensiveCombatBlock, IMyEntity, IMyEntity, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4?view=netframework-4.6)

