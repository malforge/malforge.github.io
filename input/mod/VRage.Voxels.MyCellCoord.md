**Assembly:** VRage.dll

```csharp
public struct MyCellCoord: IComparable<MyCellCoord>, IEquatable<MyCellCoord>
```

## Fields

|Member|Description|
|---|---|
|[static Comparer](VRage.Voxels.MyCellCoord@Comparer)||
|[static MAX_LOD_COUNT](VRage.Voxels.MyCellCoord@MAX_LOD_COUNT)||
|[CoordInLod](VRage.Voxels.MyCellCoord@CoordInLod)||
|[Lod](VRage.Voxels.MyCellCoord@Lod)|0 is the most detailed.|

## Constructors

|Member|Description|
|---|---|
|[MyCellCoord(ulong)](VRage.Voxels.MyCellCoord@.ctor)||
|[MyCellCoord(int, Vector3I)](VRage.Voxels.MyCellCoord@.ctor)||
|[MyCellCoord(int, ref Vector3I)](VRage.Voxels.MyCellCoord@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static GetClipmapCellHash(uint, MyCellCoord)](VRage.Voxels.MyCellCoord@GetClipmapCellHash)||
|[static GetClipmapCellHash(uint, ulong)](VRage.Voxels.MyCellCoord@GetClipmapCellHash)||
|[static PackId64Static(int, Vector3I)](VRage.Voxels.MyCellCoord@PackId64Static)||
|[static UnpackCoord(ulong)](VRage.Voxels.MyCellCoord@UnpackCoord)||
|[static UnpackLod(ulong)](VRage.Voxels.MyCellCoord@UnpackLod)||
|[CompareTo(MyCellCoord)](VRage.Voxels.MyCellCoord@CompareTo)||
|[Equals(object)](VRage.Voxels.MyCellCoord@Equals)||
|[Equals(MyCellCoord)](VRage.Voxels.MyCellCoord@Equals)||
|[GetHashCode()](VRage.Voxels.MyCellCoord@GetHashCode)||
|[IsCoord64Valid()](VRage.Voxels.MyCellCoord@IsCoord64Valid)||
|[PackId32()](VRage.Voxels.MyCellCoord@PackId32)||
|[PackId64()](VRage.Voxels.MyCellCoord@PackId64)||
|[SetUnpack(uint)](VRage.Voxels.MyCellCoord@SetUnpack)||
|[SetUnpack(ulong)](VRage.Voxels.MyCellCoord@SetUnpack)||
|[ToString()](VRage.Voxels.MyCellCoord@ToString)||

**Implements:**  
* [IComparable<MyCellCoord>](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable<MyCellCoord>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

