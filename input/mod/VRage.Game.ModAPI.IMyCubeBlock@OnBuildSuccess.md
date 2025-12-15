## Summary

```csharp
public void OnBuildSuccess(long builtBy)
```

Method called when a block has been built (after adding to the grid). This is called right after placing the block and it doesn't matter whether it is fully built (creative mode) or is only construction site. Note that it is not called for blocks which do not create FatBlock at that moment.

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builtBy
## Summary

```csharp
public void OnBuildSuccess(long builtBy, bool instantBuild)
```

Method called when a block has been built (after adding to the grid). This is called right after placing the block and it doesn't matter whether it is fully built (creative mode) or is only construction site. Note that it is not called for blocks which do not create FatBlock at that moment.

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builtBy
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) instantBuild
