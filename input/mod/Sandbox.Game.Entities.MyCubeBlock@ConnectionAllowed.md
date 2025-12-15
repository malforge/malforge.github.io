## Summary

```csharp
public virtual bool ConnectionAllowed(ref Vector3I otherBlockPos, ref Vector3I faceNormal, MyCubeBlockDefinition def)
```

Returns true if this block can connect to another block (of the given type) in the given position. This is called only if CheckConnectionAllowed == true. If this method would return true for any position, set CheckConnectionAllowed to false to avoid unnecessary overhead. It is the block's responsibility to call CubeGrid.UpdateBlockNeighbors every time the conditions that are checked by this method change.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [Vector3I](VRageMath.Vector3I) otherBlockPos
* [Vector3I](VRageMath.Vector3I) faceNormal
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) def
## Summary

```csharp
public virtual bool ConnectionAllowed(ref Vector3I otherBlockMinPos, ref Vector3I otherBlockMaxPos, ref Vector3I faceNormal, MyCubeBlockDefinition def)
```

Whether connection is allowed to any of the positions between otherBlockMinPos and otherBlockMaxPos (both inclusive). Default implementation calls ConnectionAllowed(ref Vector3I otherBlockPos, ref Vector3I faceNormal) in a for loop. Override this in a subclass if this is not needed (for example, because all calls would return the same value for the same face)

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [Vector3I](VRageMath.Vector3I) otherBlockMinPos
* [Vector3I](VRageMath.Vector3I) otherBlockMaxPos
* [Vector3I](VRageMath.Vector3I) faceNormal
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) def
