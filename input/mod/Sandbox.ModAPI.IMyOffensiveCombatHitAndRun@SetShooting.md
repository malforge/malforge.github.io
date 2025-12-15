## Summary

```csharp
public Action<IMyTerminalBlock, bool, double, Vector3D?, Direction> SetShooting { get; set; }
```

Gets or sets function that is called per block requesting it start or stop shooting. Used for adding custom weapons. By default used reference to Keen default function Must not be null. You need override it on server and client IMyCubeBlock - Weapon block to test bool - Should block shoot or not double - DistanceToTargetSq squared distance in meters to target Vector3D? - aim position, predicted shoot position Base6Directions.Direction - shoot direction Called in parallel update of Autopilot

## Returns

[Action<IMyTerminalBlock, bool, double, Vector3D?, Direction>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-5?view=netframework-4.6)

