## Summary

```csharp
public void Build(IMySlimBlock cubeBlock, long owner, long builder, bool requestInstant, long builtBy)
```

Adds the first component to construction stockpile and creates the block. This doesn't remove materials from inventory on its own.

## Parameters

* [IMySlimBlock](VRage.Game.ModAPI.IMySlimBlock) cubeBlock
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) owner
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builder
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) requestInstant
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builtBy
