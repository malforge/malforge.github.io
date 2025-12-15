**Assembly:** VRage.Render.dll

```csharp
public class MyBillboard: IComparable
```

This class is used for storing and sorting particle billboards You can change it's values ONLY WITH MyTransparentGeometry.ApplyActionOnPersistentBillboards

## Fields

|Member|Description|
|---|---|
|[AlphaCutout](VRageRender.MyBillboard@AlphaCutout)||
|[BlendType](VRageRender.MyBillboard@BlendType)||
|[Color](VRageRender.MyBillboard@Color)|ColorExtensions.ToLinearRGB((Vector4)Color.Aqua) Color depends on AlphaMisting of material. You can get material properties with MyDefinitionManager.Static.GetTransparentMaterialDefinitions()|
|[ColorIntensity](VRageRender.MyBillboard@ColorIntensity)|Default is 1, zero makes billboard - black|
|[CustomViewProjection](VRageRender.MyBillboard@CustomViewProjection)||
|[DistanceSquared](VRageRender.MyBillboard@DistanceSquared)||
|[LocalType](VRageRender.MyBillboard@LocalType)||
|[Material](VRageRender.MyBillboard@Material)||
|[ParentID](VRageRender.MyBillboard@ParentID)||
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
|[CompareTo(object)](VRageRender.MyBillboard@CompareTo)||

**Implements:**  
* [IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable?view=netframework-4.6)

**Inheritors:**  
* [MyTriangleBillboard](VRageRender.MyTriangleBillboard)

