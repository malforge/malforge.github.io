## Summary

```csharp
public static IMyToolbarChangeBuilder Definition(this IMyToolbarChangeBuilder builder, int index, MyDefinitionId definitionId)
```

Places an item that selects a definition: a block to build, a tool, a consumable. This is what character toolbars hold; terminal actions are not allowed on them.

## Returns

[IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder)

The builder, or a rejected builder when no such definition is loaded.

## Parameters

* [IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder) builder
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
* [MyDefinitionId](VRage.Game.MyDefinitionId) definitionId
