**Assembly:** VRage.Game.dll

```csharp
public class MyTransparentGeometry
```

## Properties

|Member|Description|
|---|---|
|[static Camera](VRage.Game.MyTransparentGeometry@Camera)||
|[static CameraView](VRage.Game.MyTransparentGeometry@CameraView)||
|[static HasCamera](VRage.Game.MyTransparentGeometry@HasCamera)||

## Constructors

|Member|Description|
|---|---|
|[MyTransparentGeometry()](VRage.Game.MyTransparentGeometry@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static AddAttachedQuad(MyStringId, ref MyQuadD, Vector4, ref Vector3D, uint, BlendTypeEnum, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddAttachedQuad)||
|[static AddBillboard(MyBillboard, bool)](VRage.Game.MyTransparentGeometry@AddBillboard)|Adds billboard to render. Remember, that added persistent billboard you can change ONLY with [ApplyActionOnPersistentBillboards(Action<MyBillboard>)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) and [ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) methods FOR MODDERS: If you have more than 100 billboards to remove you should use another [AddBillboards(IEnumerable<MyBillboard>, bool)](VRage.Game.MyTransparentGeometry@AddBillboards) function|
|[static AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, float, BlendTypeEnum, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddBillboardOriented)||
|[static AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, float, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddBillboardOriented)||
|[static AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, float, int, BlendTypeEnum, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddBillboardOriented)||
|[static AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, float, float, Vector2, BlendTypeEnum, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddBillboardOriented)||
|[static AddBillboardOrientedCull(Vector3, MyStringId, Vector4, Vector3, Vector3, Vector3, float, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddBillboardOrientedCull)||
|[static AddBillboards(IEnumerable<MyBillboard>, bool)](VRage.Game.MyTransparentGeometry@AddBillboards)|Adds billboards to render. Remember, that added persistent billboards you can change ONLY with [ApplyActionOnPersistentBillboards(Action<MyBillboard>)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) and [ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) methods|
|[static AddLineBillboard(MyStringId, Vector4, Vector3D, Vector3, float, float, BlendTypeEnum, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddLineBillboard)||
|[static AddLineBillboard(MyStringId, Vector4, Vector3D, uint, ref MatrixD, Vector3, float, float, BlendTypeEnum, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddLineBillboard)||
|[static AddLocalLineBillboard(MyStringId, Vector4, Vector3D, uint, Vector3, float, float, BlendTypeEnum, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddLocalLineBillboard)||
|[static AddLocalPointBillboard(MyStringId, Vector4, Vector3D, uint, float, float, BlendTypeEnum, int, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddLocalPointBillboard)||
|[static AddPointBillboard(MyStringId, Vector4, Vector3D, float, float, int, BlendTypeEnum, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddPointBillboard)||
|[static AddPointBillboard(MyStringId, Vector4, Vector3D, uint, ref MatrixD, float, float, int, BlendTypeEnum, float, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddPointBillboard)||
|[static AddQuad(MyStringId, ref MyQuadD, Vector4, ref Vector3D, int, BlendTypeEnum, List<MyBillboard>)](VRage.Game.MyTransparentGeometry@AddQuad)||
|[static ApplyActionOnPersistentBillboards(Action<MyBillboard>)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards)|Used to update billboards. It iterates over each MyBillBoard. Use [ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) if you need iterate over specific billboards.|
|[static ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards)|Used to update billboards. You can change any values of MyBillboard inside of this action call. Used to iterate over your own set of Billboards, instead of all, that currently drawing.|
|[static CreateBillboard(MyBillboard, ref MyQuadD, MyStringId, ref Vector4, ref Vector3D, int, float)](VRage.Game.MyTransparentGeometry@CreateBillboard)||
|[static CreateBillboard(MyBillboard, ref MyQuadD, MyStringId, ref Vector4, ref Vector3D, Vector2, int, float)](VRage.Game.MyTransparentGeometry@CreateBillboard)||
|[static EndParticleProfilingBlock()](VRage.Game.MyTransparentGeometry@EndParticleProfilingBlock)||
|[static RemovePersistentBillboard(MyBillboard, bool)](VRage.Game.MyTransparentGeometry@RemovePersistentBillboard)|Removes one persistent billboard from draw FOR MODDERS: If you have more than 100 billboards to remove you should use another [RemovePersistentBillboards(IEnumerable<MyBillboard>, bool)](VRage.Game.MyTransparentGeometry@RemovePersistentBillboards) function|
|[static RemovePersistentBillboards(IEnumerable<MyBillboard>, bool)](VRage.Game.MyTransparentGeometry@RemovePersistentBillboards)|Removes multiple persistent billboard from draw|
|[static SetCamera(MyCamera)](VRage.Game.MyTransparentGeometry@SetCamera)||
|[static StartParticleProfilingBlock(string)](VRage.Game.MyTransparentGeometry@StartParticleProfilingBlock)||
|[static AddTriangleBillboard(Vector3D, Vector3D, Vector3D, Vector3, Vector3, Vector3, Vector2, Vector2, Vector2, MyStringId, uint, Vector3D, BlendTypeEnum)](VRage.Game.MyTransparentGeometry@AddTriangleBillboard)|_**Obsolete:** Only for modders_|
|[static AddTriangleBillboard(Vector3D, Vector3D, Vector3D, Vector3, Vector3, Vector3, Vector2, Vector2, Vector2, MyStringId, uint, Vector3D, Vector4, BlendTypeEnum)](VRage.Game.MyTransparentGeometry@AddTriangleBillboard)|_**Obsolete:** Only for modders_|

