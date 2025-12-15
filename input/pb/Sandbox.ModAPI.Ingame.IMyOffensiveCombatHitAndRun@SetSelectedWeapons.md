## Summary

```csharp
public void SetSelectedWeapons(List<long> blockEntityId)
```

Sets weapons EntityIds that can would be used to damage to attack enemy Modded gun are allowed, but you need override `IMyOffensiveCombatHitAndRun.BlockValidation`<sub>prohibited</sub> and `IMyOffensiveCombatHitAndRun.SetShooting`<sub>prohibited</sub> 

## Parameters

* [List<long>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) blockEntityId
