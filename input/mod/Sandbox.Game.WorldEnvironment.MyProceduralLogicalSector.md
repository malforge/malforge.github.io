**Assembly:** Sandbox.Game.dll

```csharp
public class MyProceduralLogicalSector: MyLogicalEnvironmentSectorBase, IMyEventProxy, IMyEventOwner
```

## Fields

|Member|Description|
|---|---|
|[Bounds](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Bounds)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[Id](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Id)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[WorldPos](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@WorldPos)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|

## Events

|Member|Description|
|---|---|
|[OnViewerEmpty](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@OnViewerEmpty)||
|[OnClose](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@OnClose)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|

## Properties

|Member|Description|
|---|---|
|[DebugData](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@DebugData)||
|[ServerOwned](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@ServerOwned)||
|[DebugData](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@DebugData)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[MinLod](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@MinLod)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[Owner](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Owner)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[ServerOwned](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@ServerOwned)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyProceduralLogicalSector(MyProceduralEnvironmentProvider, int, int, int, MyObjectBuilder_ProceduralEnvironmentSector)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddView(MyProceduralDataView, Vector3D, int)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@AddView)||
|[Close()](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@Close)||
|[DebugDraw(int)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@DebugDraw)||
|[DisableItemsInBox(Vector3D, ref BoundingBoxD)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@DisableItemsInBox)||
|[EnableItem(int, bool)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@EnableItem)||
|[GetItem(int, out ItemInfo)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@GetItem)||
|[GetItemDefinition(ushort, out MyRuntimeEnvironmentItemInfo)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@GetItemDefinition)||
|[GetItemDefinitionId(int)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@GetItemDefinitionId)||
|[GetItemsInAabb(ref BoundingBoxD, List<int>)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@GetItemsInAabb)||
|[GetObjectBuilder()](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@GetObjectBuilder)||
|[Init(MyObjectBuilder_EnvironmentSector)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@Init)||
|[InvalidateItem(int)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@InvalidateItem)||
|[IterateItems(ItemIterator)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@IterateItems)||
|[RaiseItemEvent<TModule>(int, object, bool)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@RaiseItemEvent{TModule})||
|[RaiseItemEvent<T>(int, ref MyDefinitionId, T, bool)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@RaiseItemEvent{T})||
|[ReenableItem(int)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@ReenableItem)||
|[RemoveView(MyProceduralDataView)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@RemoveView)||
|[RevalidateItem(int)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@RevalidateItem)||
|[ToString()](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@ToString)||
|[UpdateItemModel(int, short)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@UpdateItemModel)||
|[UpdateItemModelBatch(List<int>, short)](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector@UpdateItemModelBatch)||
|[Close()](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Close)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[DebugDraw(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@DebugDraw)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[DisableItemsInBox(Vector3D, ref BoundingBoxD)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@DisableItemsInBox)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[EnableItem(int, bool)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@EnableItem)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[GetItem(int, out ItemInfo)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItem)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[GetItemDefinition(ushort, out MyRuntimeEnvironmentItemInfo)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItemDefinition)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[GetItemDefinitionId(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItemDefinitionId)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[GetItemsInAabb(ref BoundingBoxD, List<int>)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItemsInAabb)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[GetObjectBuilder()](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetObjectBuilder)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[Init(MyObjectBuilder_EnvironmentSector)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Init)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[InvalidateItem(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@InvalidateItem)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[IterateItems(ItemIterator)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@IterateItems)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[RaiseItemEvent<T>(int, ref MyDefinitionId, T, bool)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@RaiseItemEvent{T})|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[RevalidateItem(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@RevalidateItem)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[UpdateItemModel(int, short)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@UpdateItemModel)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|
|[UpdateItemModelBatch(List<int>, short)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@UpdateItemModelBatch)|_Inherited from [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)_|

**Inheritance:**   [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)

**Implements:**  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)

