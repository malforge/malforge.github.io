## Summary

```csharp
public bool IsPlaceUsed(Vector3D position, double eventSpaceMapping, int currentTimeMs, bool autoinsert)
```

Helper function. Check temporal usage of space. Check whether the place is taken. Internally converts position to generic item. Please use consistent eventSpaceMapping, otherwise cache will not find your items. autoinsert param: If the item is not found, it is inserted to the cache if the argument autoinsert is true.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [Vector3D](VRageMath.Vector3D) position
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) eventSpaceMapping
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) currentTimeMs
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) autoinsert
