## Summary

```csharp
public bool IsInSameLogicalGroupAs(IMyCubeGrid other)
```

Determines whether this grid is in the same logical group as the other, meaning they're connected either mechanically or via blocks like connectors. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

If grids connected logically

## Parameters

* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) other
