## Summary

```csharp
public String[] NPCSpawnBlocksOverride { get; }
```

Block subtypes the prefab's NPCs spawn at, one bot per matching block, instead of any free seat; a listed seat is sat in, other blocks are stood in. Null means "seats only"; explicit [NPCSpawnPointsOverride](Sandbox.Definitions.MyPrefabDefinition@NPCSpawnPointsOverride) positions take precedence over both.

## Returns

[string[]](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6)

