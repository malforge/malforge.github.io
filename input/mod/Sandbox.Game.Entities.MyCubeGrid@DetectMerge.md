## Summary

```csharp
public MyCubeGrid DetectMerge(MySlimBlock block, MyCubeGrid ignore, List<MyEntity> nearEntities, bool newGrid)
```

Tries to merge this grid with any other grid Merges grids only when both are static Returns the merged grid (which does not necessarily have to be this grid)

## Returns

[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)

## Parameters

* MySlimBlock <sub>prohibited</sub> block
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) ignore
* [List<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) nearEntities
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) newGrid
