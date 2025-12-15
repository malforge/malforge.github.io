**Assembly:** Sandbox.Game.dll

```csharp
public class MyGridLogicalGroupData: MyGridGroupData<MyGridLogicalGroupData>, IGroupData<MyCubeGrid>, IMyGridGroupData
```

## Events

|Member|Description|
|---|---|
|[OnGridAdded](VRage.Game.ModAPI.IMyGridGroupData@OnGridAdded)|First MyGridGroupData(this) - where grid would be added Second MyGridGroupData(Nullable) - previous grid group of grid<br /><br />_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|
|[OnGridRemoved](VRage.Game.ModAPI.IMyGridGroupData@OnGridRemoved)|First MyGridGroupData(this) - from where grid was removed Second MyGridGroupData(Nullable) - where grid group would be added Called after Keen OnAdded logic, like MyGridLogicalGroupData.OnNodeAdded<br /><br />_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|
|[OnReleased](VRage.Game.ModAPI.IMyGridGroupData@OnReleased)|You must clean your subscriptions here. Instances of IMyGridGroupData are re-used in ObjectPool. At the time event is called it has no grids attached to it.<br /><br />_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|

## Properties

|Member|Description|
|---|---|
|[Root](Sandbox.Game.Entities.MyGridLogicalGroupData@Root)||
|[LinkType](VRage.Game.ModAPI.IMyGridGroupData@LinkType)|Get connection type<br /><br />_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|

## Constructors

|Member|Description|
|---|---|
|[MyGridLogicalGroupData()](Sandbox.Game.Entities.MyGridLogicalGroupData@.ctor)||

## Methods

|Member|Description|
|---|---|
|[OnCreate<TGroupData>(Group<MyCubeGrid, TGroupData>)](Sandbox.Game.Entities.MyGridLogicalGroupData@OnCreate{TGroupData})||
|[OnNodeAdded<TGroupData>(MyCubeGrid, TGroupData)](Sandbox.Game.Entities.MyGridLogicalGroupData@OnNodeAdded{TGroupData})||
|[OnNodeRemoved<TGroupData>(MyCubeGrid, TGroupData)](Sandbox.Game.Entities.MyGridLogicalGroupData@OnNodeRemoved{TGroupData})||
|[OnRelease()](Sandbox.Game.Entities.MyGridLogicalGroupData@OnRelease)||
|[GetGrids<T>(T)](VRage.Game.ModAPI.IMyGridGroupData@GetGrids{T})|_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|
|[GetVariable<T>(Guid)](VRage.Game.ModAPI.IMyGridGroupData@GetVariable{T})|_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|
|[RemoveVariable(Guid)](VRage.Game.ModAPI.IMyGridGroupData@RemoveVariable)|Removes stored variable<br /><br />_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|
|[SetVariable(Guid, object)](VRage.Game.ModAPI.IMyGridGroupData@SetVariable)|Sets memory-stored variable<br /><br />_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|
|[TryGetVariable<T>(Guid, out T)](VRage.Game.ModAPI.IMyGridGroupData@TryGetVariable{T})|_Inherited from [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)_|

**Inheritance:**   MyGridGroupData <sub>prohibited</sub>

**Implements:**  
* IGroupData<MyCubeGrid> <sub>prohibited</sub>  
* [IMyGridGroupData](VRage.Game.ModAPI.IMyGridGroupData)

