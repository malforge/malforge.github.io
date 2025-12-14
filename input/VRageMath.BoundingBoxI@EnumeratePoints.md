## Summary

```csharp
public static IEnumerable<Vector3I> EnumeratePoints(BoundingBoxI rangeInclusive)
```

Enumerate all values in a integer interval (a cuboid). This method is an allocating version of the Vector3I_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

## Returns

[IEnumerable<Vector3I>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

An iterator for that range.

## Parameters

* [BoundingBoxI](VRageMath.BoundingBoxI) rangeInclusive
