**Assembly:** VRage.Game.dll

```csharp
public interface IMyCamera
```

Describes camera (mods interface)

## Properties

|Member|Description|
|---|---|
|[FarPlaneDistance](VRage.ModAPI.IMyCamera@FarPlaneDistance)|Gets farplane is set by MyObjectBuilder_SessionSettings.ViewDistance|
|[FieldOfViewAngle](VRage.ModAPI.IMyCamera@FieldOfViewAngle)|Gets field of view angle in degrees|
|[FovWithZoom](VRage.ModAPI.IMyCamera@FovWithZoom)|Gets field of view with zoom|
|[NearPlaneDistance](VRage.ModAPI.IMyCamera@NearPlaneDistance)|Gets near plane distance|
|[Position](VRage.ModAPI.IMyCamera@Position)|Gets camera position|
|[PreviousPosition](VRage.ModAPI.IMyCamera@PreviousPosition)|Gets camera previous position|
|[ProjectionMatrix](VRage.ModAPI.IMyCamera@ProjectionMatrix)|Gets projection matrix|
|[ViewMatrix](VRage.ModAPI.IMyCamera@ViewMatrix)|Gets view matrix when camera in real position|
|[ViewportOffset](VRage.ModAPI.IMyCamera@ViewportOffset)|Gets camera viewport offset|
|[ViewportSize](VRage.ModAPI.IMyCamera@ViewportSize)|Gets camera viewport size|
|[WorldMatrix](VRage.ModAPI.IMyCamera@WorldMatrix)|Gets camera world matrix|
|[FieldOfViewAngleForNearObjects](VRage.ModAPI.IMyCamera@FieldOfViewAngleForNearObjects)|_**Obsolete**_|
|[FovWithZoomForNearObjects](VRage.ModAPI.IMyCamera@FovWithZoomForNearObjects)|_**Obsolete**_|
|[ProjectionMatrixForNearObjects](VRage.ModAPI.IMyCamera@ProjectionMatrixForNearObjects)|_**Obsolete**_|

## Methods

|Member|Description|
|---|---|
|[GetDistanceWithFOV(Vector3D)](VRage.ModAPI.IMyCamera@GetDistanceWithFOV)|Gets distance from point. Equals to [Distance(Vector3D, Vector3D)](VRageMath.Vector3D@Distance) |
|[IsInFrustum(ref BoundingBoxD)](VRage.ModAPI.IMyCamera@IsInFrustum)|Checks if specified bounding box is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding box. Don't use BoundingBox.Transform. Instead transform box manualy and then create new box.|
|[IsInFrustum(ref BoundingSphereD)](VRage.ModAPI.IMyCamera@IsInFrustum)|Checks if specified bounding sphere is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding sphere. Don't use BoundingSphere.Transform. Instead transform sphere center manualy and then create new sphere.|
|[IsInFrustum(BoundingBoxD)](VRage.ModAPI.IMyCamera@IsInFrustum)|Checks if specified bounding box is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding box. Don't use BoundingBox.Transform. Instead transform box manualy and then create new box.|
|[WorldLineFromScreen(Vector2)](VRage.ModAPI.IMyCamera@WorldLineFromScreen)|Gets normalized world space line from screen space coordinates.|
|[WorldToScreen(ref Vector3D)](VRage.ModAPI.IMyCamera@WorldToScreen)|Gets screen coordinates of 3d world pos in 0 - 1 distance where 1.0 is screen width(for X) or height(for Y). WARNING: Y is from bottom to top.|

