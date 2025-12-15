## Summary

```csharp
public bool IsSameConstructAs(IMyTerminalBlock other)
```

Determines whether this block is mechanically connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if blocks belongs to same grids, or their grids connected with [Logical](VRage.Game.ModAPI.GridLinkTypeEnum@Logical) 

## Parameters

* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock) other
