## Summary

```csharp
public static Vector3 ForwardVectorProjection(Vector3 forwardVector, Vector3 projectedVector)
```

This projection results to initial velocity of non-engine objects, which parents move in some velocity We want to add only forward speed of the parent to the forward direction of the object, and if parent is going backward, no speed is added.

## Returns

[Vector3](VRageMath.Vector3)



## Parameters

* [Vector3](VRageMath.Vector3) forwardVector
* [Vector3](VRageMath.Vector3) projectedVector
