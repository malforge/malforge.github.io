## Summary

```csharp
public static uint PARENT_ID_CAMERA
```

Set as [ParentID](VRageRender.MyBillboard@ParentID) to declare the positions camera-local. The renderer then places the billboard with the camera it actually draws that frame with, which is what keeps screen-anchored content pinned — positions derived from the game-side camera matrix are a tick stale and swim once the camera is interpolated.

## Returns

[uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6)

