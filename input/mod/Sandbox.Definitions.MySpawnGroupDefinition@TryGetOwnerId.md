## Summary

```csharp
public bool TryGetOwnerId(out long ownerId, bool isGlobalSubEncounter)
```

Tries to get owner id for spawning this group based on [FactionSubtypeIds](Sandbox.Definitions.MySpawnGroupDefinition@FactionSubtypeIds) and [FactionTypesSubtypeIds](Sandbox.Definitions.MySpawnGroupDefinition@FactionTypesSubtypeIds) 

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if target faction was found, false otherwise

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) ownerId
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isGlobalSubEncounter
