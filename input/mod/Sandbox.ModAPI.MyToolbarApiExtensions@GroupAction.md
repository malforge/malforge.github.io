## Summary

```csharp
public static IMyToolbarChangeBuilder GroupAction(this IMyToolbarChangeBuilder builder, int index, IMyTerminalBlock contextBlock, string groupName, string actionId, List<TerminalActionParameter> parameters, string label)
```

Places an item that runs a terminal action on a block group.

## Returns

[IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder)

The builder. The group and action are resolved when the batch is applied, so unknown names leave the slot empty rather than rejecting the batch.

## Parameters

* [IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder) builder
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock) contextBlock
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) groupName
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) actionId
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter)&gt; parameters
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) label
