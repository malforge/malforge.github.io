## Summary

```csharp
public IMyCubeGrid Split(List<IMySlimBlock> blocks, bool sync)
```

Split grid

## Returns

[IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)

New grid

## Parameters

* [List<IMySlimBlock>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) blocks
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) sync
## Remarks

To sync to clients, this must be called on the server with sync = true.

