## Summary

```csharp
public static IEnumerable<Vector3L> EnumerateRange(Vector3L minInclusive, Vector3L maxExclusive)
```

Enumerate all values in a longeger longerval (a cuboid). This method is an allocating version of the Vector3L_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

## Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[Vector3L](VRageMath.Vector3L)&gt;

An iterator for that range.

## Parameters

* [Vector3L](VRageMath.Vector3L) minInclusive
* [Vector3L](VRageMath.Vector3L) maxExclusive
