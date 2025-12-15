## Summary

```csharp
public void RequestJump(string destinationName, Vector3D destination, long userId, BoundingBoxD? shipBox, float jumpDriveDelay, long? driveEntityId)
```

Requests the pilot or local player to jump (Prompts the pilot with the jump UI, they can cancel the jump or say yes)

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) destinationName
* [Vector3D](VRageMath.Vector3D) destination
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) userId
* [BoundingBoxD?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) shipBox
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) jumpDriveDelay
* [long?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) driveEntityId
## Summary

```csharp
public void RequestJump(Vector3D jumpTarget, long userId, float jumpDriveDelay, long? driveEntityId)
```

Requests the pilot or local player to jump (Prompts the pilot with the jump UI, they can cancel the jump or say yes)

## Parameters

* [Vector3D](VRageMath.Vector3D) jumpTarget
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) userId
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) jumpDriveDelay
* [long?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) driveEntityId
