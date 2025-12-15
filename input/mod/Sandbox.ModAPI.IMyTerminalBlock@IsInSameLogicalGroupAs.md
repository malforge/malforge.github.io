## Summary

```csharp
public bool IsInSameLogicalGroupAs(IMyTerminalBlock other)
```

Determines whether this block is in the same logical group as the other, meaning they're connected either mechanically or via blocks like connectors. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if blocks belongs to same grids, or their grids connected with [Logical](VRage.Game.ModAPI.GridLinkTypeEnum@Logical) 

## Parameters

* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock) other
