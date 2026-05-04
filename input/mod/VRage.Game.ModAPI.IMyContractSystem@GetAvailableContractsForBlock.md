## Summary

```csharp
public ListReader<IMyContract> GetAvailableContractsForBlock(long blockId)
```

Gets available (inactive) contracts for block. This list does not contain contracts for stations.

## Returns

[ListReader<IMyContract>](VRage.Collections.ListReader{IMyContract})

null if block does no exist or dont have any contract

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) blockId
