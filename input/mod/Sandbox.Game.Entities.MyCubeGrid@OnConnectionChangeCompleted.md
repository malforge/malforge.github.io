## Summary

```csharp
public Action<MyCubeGrid, GridLinkTypeEnum> event OnConnectionChangeCompleted
```

Event triggered, when one of GridLinkTypeEnum connections changed. Used to determine changes in connections. Use may also need react to OnGridMerge/OnGridSplit Event different from OnConnectivityChanged. 1) It is called when all group changes 2) It is called AFTER all group changes, so GetConnectedGrids returning correct results

## Returns

[Action<MyCubeGrid, GridLinkTypeEnum>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)

