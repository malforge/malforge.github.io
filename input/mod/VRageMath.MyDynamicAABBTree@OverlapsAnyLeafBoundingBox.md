## Summary

```csharp
public bool OverlapsAnyLeafBoundingBox(ref BoundingBox bbox)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [BoundingBox](VRageMath.BoundingBox) bbox
## Summary

```csharp
public bool OverlapsAnyLeafBoundingBox(ref BoundingBox bbox, uint requiredFlags)
```

Whether any leaf carrying every bit ofrequiredFlagsoverlaps the box. Early-outs on the first hit, and rejects at the root for a box outside the tree.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [BoundingBox](VRageMath.BoundingBox) bbox
* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) requiredFlags
