## Summary

```csharp
public static IMyToolbarChangeBuilder BlockAction(this IMyToolbarChangeBuilder builder, int index, IMyTerminalBlock block, string actionId, List<TerminalActionParameter> parameters, string label)
```

Places an item that runs one of a block's terminal actions.

## Returns

[IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder)

The builder. The action is resolved when the batch is applied, so an unknown identifier leaves the slot empty rather than rejecting the batch.

## Parameters

* [IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder) builder
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock) block
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) actionId
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter)&gt; parameters
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) label
