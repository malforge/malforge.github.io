## Summary

```csharp
public bool IsTouchingAnyNeighbor(Vector3I min, Vector3I max)
```

Finds out if given area has any neighboring block Checking only cube sides. Example: for vectors Min (0,0,0) and Max (10,10,10), Space (1,1,1)-(9,9,9) won't be checked

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if given area has at least one block

## Parameters

* [Vector3I](VRageMath.Vector3I) min
* [Vector3I](VRageMath.Vector3I) max
