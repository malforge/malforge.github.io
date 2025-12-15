**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridGroupData
```

A class that presenting connection between grids WARNING: you must not keep link to instance or you have to remove link when event OnReleased is fired Use Get/SetVariable to store data in GridGroups. Variables are cleared after OnRelease is fired

## Events

|Member|Description|
|---|---|
|[OnGridAdded](VRage.Game.ModAPI.IMyGridGroupData@OnGridAdded)|First MyGridGroupData(this) - where grid would be added Second MyGridGroupData(Nullable) - previous grid group of grid|
|[OnGridRemoved](VRage.Game.ModAPI.IMyGridGroupData@OnGridRemoved)|First MyGridGroupData(this) - from where grid was removed Second MyGridGroupData(Nullable) - where grid group would be added Called after Keen OnAdded logic, like MyGridLogicalGroupData.OnNodeAdded|
|[OnReleased](VRage.Game.ModAPI.IMyGridGroupData@OnReleased)|You must clean your subscriptions here. Instances of IMyGridGroupData are re-used in ObjectPool. At the time event is called it has no grids attached to it.|

## Properties

|Member|Description|
|---|---|
|[LinkType](VRage.Game.ModAPI.IMyGridGroupData@LinkType)|Get connection type|

## Methods

|Member|Description|
|---|---|
|[GetGrids<T>(T)](VRage.Game.ModAPI.IMyGridGroupData@GetGrids{T})||
|[GetVariable<T>(Guid)](VRage.Game.ModAPI.IMyGridGroupData@GetVariable{T})||
|[RemoveVariable(Guid)](VRage.Game.ModAPI.IMyGridGroupData@RemoveVariable)|Removes stored variable|
|[SetVariable(Guid, object)](VRage.Game.ModAPI.IMyGridGroupData@SetVariable)|Sets memory-stored variable|
|[TryGetVariable<T>(Guid, out T)](VRage.Game.ModAPI.IMyGridGroupData@TryGetVariable{T})||

**Inheritors:**  
* [MyGridLogicalGroupData](Sandbox.Game.Entities.MyGridLogicalGroupData)  
* [MyGridMechanicalGroupData](Sandbox.Game.Entities.MyGridMechanicalGroupData)  
* [MyGridPhysicalGroupData](Sandbox.Game.Entities.MyGridPhysicalGroupData)

