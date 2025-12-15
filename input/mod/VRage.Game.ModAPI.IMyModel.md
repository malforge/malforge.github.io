**Assembly:** VRage.Game.dll

```csharp
public interface IMyModel
```

Describes 3D model (mods interface)

## Properties

|Member|Description|
|---|---|
|[AssetName](VRage.Game.ModAPI.IMyModel@AssetName)|File path of the model|
|[BoneMapping](VRage.Game.ModAPI.IMyModel@BoneMapping)||
|[BoundingBox](VRage.Game.ModAPI.IMyModel@BoundingBox)|Gets bounding box|
|[BoundingBoxSize](VRage.Game.ModAPI.IMyModel@BoundingBoxSize)|Gets bounding box size|
|[BoundingBoxSizeHalf](VRage.Game.ModAPI.IMyModel@BoundingBoxSizeHalf)|Gets bounding box size|
|[BoundingSphere](VRage.Game.ModAPI.IMyModel@BoundingSphere)|Gets bounding sphere|
|[DataVersion](VRage.Game.ModAPI.IMyModel@DataVersion)|Get version of model|
|[PatternScale](VRage.Game.ModAPI.IMyModel@PatternScale)|Used in texturing of armor blocks. Default is 1|
|[ScaleFactor](VRage.Game.ModAPI.IMyModel@ScaleFactor)|Scale of model. Default 1. Greater number - bigger model|
|[UniqueId](VRage.Game.ModAPI.IMyModel@UniqueId)|Gets id of model|

## Methods

|Member|Description|
|---|---|
|[GetDrawTechnique(int)](VRage.Game.ModAPI.IMyModel@GetDrawTechnique)|Gets [MyMeshDrawTechnique](VRageRender.Import.MyMeshDrawTechnique) by triangle index|
|[GetDummies(IDictionary<string, IMyModelDummy>)](VRage.Game.ModAPI.IMyModel@GetDummies)|Gets the dummies from the model|
|[GetTriangle(int)](VRage.Game.ModAPI.IMyModel@GetTriangle)|Gets the vertex indices that complete a triangle at the index|
|[GetTrianglesCount()](VRage.Game.ModAPI.IMyModel@GetTrianglesCount)|Gets amount of triangles|
|[GetVertex(int)](VRage.Game.ModAPI.IMyModel@GetVertex)|Gets the vertex|
|[GetVertex(int, int, int, out Vector3, out Vector3, out Vector3)](VRage.Game.ModAPI.IMyModel@GetVertex)|Gets a set of three vertices|
|[GetVerticesCount()](VRage.Game.ModAPI.IMyModel@GetVerticesCount)|Gets amount of vertices|

