**Assembly:** VRage.Render.dll

```csharp
public class MyBillboard: IComparable, IComparable<MyBillboard>
```

This class is used for storing and sorting particle billboards You can change it's values ONLY WITH MyTransparentGeometry.ApplyActionOnPersistentBillboards

## Fields

|Member|Description|
|---|---|
|[static PARENT_ID_CAMERA](VRageRender.MyBillboard@PARENT_ID_CAMERA)|Set as [ParentID](VRageRender.MyBillboard@ParentID) to declare the positions camera-local. The renderer then places the billboard with the camera it actually draws that frame with, which is what keeps screen-anchored content pinned — positions derived from the game-side camera matrix are a tick stale and swim once the camera is interpolated.|
|[AlphaCutout](VRageRender.MyBillboard@AlphaCutout)||
|[BlendType](VRageRender.MyBillboard@BlendType)||
|[Color](VRageRender.MyBillboard@Color)|ColorExtensions.ToLinearRGB((Vector4)Color.Aqua) Color depends on AlphaMisting of material. You can get material properties with MyDefinitionManager.Static.GetTransparentMaterialDefinitions()|
|[ColorIntensity](VRageRender.MyBillboard@ColorIntensity)|Default is 1, zero makes billboard - black|
|[CustomViewProjection](VRageRender.MyBillboard@CustomViewProjection)||
|[DistanceSquared](VRageRender.MyBillboard@DistanceSquared)||
|[LocalType](VRageRender.MyBillboard@LocalType)||
|[Material](VRageRender.MyBillboard@Material)||
|[ParentID](VRageRender.MyBillboard@ParentID)|Render object the positions are local to, or [PARENT_ID_CAMERA](VRageRender.MyBillboard@PARENT_ID_CAMERA) for camera-local ones. Unassigned means the positions are absolute world coordinates.|
|[Position0](VRageRender.MyBillboard@Position0)||
|[Position1](VRageRender.MyBillboard@Position1)||
|[Position2](VRageRender.MyBillboard@Position2)||
|[Position3](VRageRender.MyBillboard@Position3)||
|[Reflectivity](VRageRender.MyBillboard@Reflectivity)||
|[SoftParticleDistanceScale](VRageRender.MyBillboard@SoftParticleDistanceScale)||
|[UVOffset](VRageRender.MyBillboard@UVOffset)|Default is Vector2.Zero|
|[UVSize](VRageRender.MyBillboard@UVSize)|Default is Vector2 (1,1)|

## Constructors

|Member|Description|
|---|---|
|[MyBillboard()](VRageRender.MyBillboard@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CompareTo(MyBillboard)](VRageRender.MyBillboard@CompareTo)||
|[CompareTo(object)](VRageRender.MyBillboard@CompareTo)||

**Implements:**  
* [IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable?view=netframework-4.6)  
* [IComparable<MyBillboard>](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)

**Inheritors:**  
* [MyTriangleBillboard](VRageRender.MyTriangleBillboard)

