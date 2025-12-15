## Summary

```csharp
public bool IsSameConstructAs(IMyTerminalBlock other)
```

Determines whether this block is `Mechanical`<sub>prohibited</sub> connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.  
  
Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if blocks are on same grid, or has `Mechanical`<sub>prohibited</sub> linking

## Parameters

* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) other
