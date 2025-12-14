## Summary

```csharp
public static IEnumerable<Vector3I> IterateDifference(BoundingBoxI left, BoundingBoxI right)
```

Iterate every cell contained in {left} - {right}, where we interpret {box} as the set of all distinct Vector3I points inside a 'box'. Containment is taken in a typical inclusive start, exclusive end fashion.

## Returns

[IEnumerable<Vector3I>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)



## Parameters

* [BoundingBoxI](VRageMath.BoundingBoxI) left
* [BoundingBoxI](VRageMath.BoundingBoxI) right
