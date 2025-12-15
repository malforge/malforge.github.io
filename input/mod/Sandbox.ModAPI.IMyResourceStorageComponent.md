**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyResourceStorageComponent: IMyResourceStorageComponent
```

Describes a resource storage entity component.

## Properties

|Member|Description|
|---|---|
|[FilledRatioChanged](Sandbox.ModAPI.IMyResourceStorageComponent@FilledRatioChanged)|When FilledRatio is changed.|
|[FilledRatio](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent@FilledRatio)|Gets the current fill level of this storage as a value between 0 (empty) and 1 (full).<br /><br />_Inherited from [IMyResourceStorageComponent](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent)_|
|[ResourceCapacity](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent@ResourceCapacity)|Gets the resource capacity of this tank.<br /><br />_Inherited from [IMyResourceStorageComponent](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent)_|

## Methods

|Member|Description|
|---|---|
|[ChangeFilledRatio(double, bool)](Sandbox.ModAPI.IMyResourceStorageComponent@ChangeFilledRatio)|Allows you to set the fill ratio of a storage|
|[IsResourceStorage(MyDefinitionId)](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent@IsResourceStorage)|Can the storage store a specified resource?<br /><br />_Inherited from [IMyResourceStorageComponent](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent)_|

**Implements:**  
* [IMyResourceStorageComponent](Sandbox.ModAPI.Ingame.IMyResourceStorageComponent)

