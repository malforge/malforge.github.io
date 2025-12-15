## Summary

```csharp
public void RazeBlocks(ref Vector3I pos, ref Vector3UByte size, long builderEntityId)
```

## Parameters

* [Vector3I](VRageMath.Vector3I) pos
* [Vector3UByte](VRageMath.Vector3UByte) size
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builderEntityId
## Summary

```csharp
public void RazeBlocks(List<Vector3I> locations, long builderEntityId, ulong user)
```

Razes blocks (unbuild) user is used only if locally invoked, if invoked from client, sender steam id is used

## Parameters

* [List<Vector3I>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) locations
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builderEntityId
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) user
