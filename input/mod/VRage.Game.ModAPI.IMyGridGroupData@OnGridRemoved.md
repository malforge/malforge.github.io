## Summary

```csharp
public Action<IMyGridGroupData, IMyCubeGrid, IMyGridGroupData> event OnGridRemoved
```

First MyGridGroupData(this) - from where grid was removed Second MyGridGroupData(Nullable) - where grid group would be added Called after Keen OnAdded logic, like MyGridLogicalGroupData.OnNodeAdded

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3?view=netframework-4.6)&lt;[IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData), [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid), [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)&gt;

