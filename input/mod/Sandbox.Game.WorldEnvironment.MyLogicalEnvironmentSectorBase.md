**Assembly:** Sandbox.Game.dll

```csharp
public abstract class MyLogicalEnvironmentSectorBase: IMyEventProxy, IMyEventOwner
```

## Fields

|Member|Description|
|---|---|
|[Bounds](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Bounds)||
|[Id](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Id)||
|[WorldPos](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@WorldPos)||

## Events

|Member|Description|
|---|---|
|[OnClose](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@OnClose)||

## Properties

|Member|Description|
|---|---|
|[DebugData](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@DebugData)||
|[MinLod](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@MinLod)||
|[Owner](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Owner)||
|[ServerOwned](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@ServerOwned)||

## Methods

|Member|Description|
|---|---|
|[Close()](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Close)||
|[DebugDraw(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@DebugDraw)||
|[DisableItemsInBox(Vector3D, ref BoundingBoxD)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@DisableItemsInBox)||
|[EnableItem(int, bool)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@EnableItem)||
|[GetItem(int, out ItemInfo)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItem)||
|[GetItemDefinition(ushort, out MyRuntimeEnvironmentItemInfo)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItemDefinition)||
|[GetItemDefinitionId(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItemDefinitionId)||
|[GetItemsInAabb(ref BoundingBoxD, List<int>)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetItemsInAabb)||
|[GetObjectBuilder()](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@GetObjectBuilder)||
|[Init(MyObjectBuilder_EnvironmentSector)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@Init)||
|[InvalidateItem(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@InvalidateItem)||
|[IterateItems(ItemIterator)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@IterateItems)||
|[RaiseItemEvent<T>(int, ref MyDefinitionId, T, bool)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@RaiseItemEvent{T})||
|[RevalidateItem(int)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@RevalidateItem)||
|[UpdateItemModel(int, short)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@UpdateItemModel)||
|[UpdateItemModelBatch(List<int>, short)](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase@UpdateItemModelBatch)||

**Implements:**  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)

**Inheritors:**  
* [MyProceduralLogicalSector](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector)

