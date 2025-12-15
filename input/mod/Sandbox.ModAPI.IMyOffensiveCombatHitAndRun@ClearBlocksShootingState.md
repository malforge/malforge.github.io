## Summary

```csharp
public Action<IMyCubeGrid, MyObjectBuilder_CubeGrid, IMyAttackPatternComponent> ClearBlocksShootingState { get; set; }
```

Gets or sets function that is called when grid is copied. You need clear state of shooting weapons By default used reference to Keen default function Must not be null. You need override it on server and client IMyCubeGrid - original grid which would be copied MyObjectBuilder_CubeGrid - grid which state you need clear IMyAttackPatternComponent - attack pattern, that calls this clear

## Returns

[Action<IMyCubeGrid, MyObjectBuilder_CubeGrid, IMyAttackPatternComponent>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3?view=netframework-4.6)

