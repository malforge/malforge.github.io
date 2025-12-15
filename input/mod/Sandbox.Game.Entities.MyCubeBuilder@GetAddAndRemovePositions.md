## Summary

```csharp
public virtual bool GetAddAndRemovePositions(float gridSize, bool placingSmallGridOnLargeStatic, out Vector3I addPos, out Vector3? addPosSmallOnLarge, out Vector3I addDir, out Vector3I removePos, out MySlimBlock removeBlock, out ushort? compoundBlockId, HashSet<Tuple`2> removeBlocksInMultiBlock)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) gridSize
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) placingSmallGridOnLargeStatic
* [Vector3I](VRageMath.Vector3I) addPos
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) addPosSmallOnLarge
* [Vector3I](VRageMath.Vector3I) addDir
* [Vector3I](VRageMath.Vector3I) removePos
* MySlimBlock <sub>prohibited</sub> removeBlock
* [ushort?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) compoundBlockId
* [HashSet<Tuple`2>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netframework-4.6) removeBlocksInMultiBlock
