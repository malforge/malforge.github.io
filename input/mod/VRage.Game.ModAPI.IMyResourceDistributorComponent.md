**Assembly:** VRage.Game.dll

```csharp
public interface IMyResourceDistributorComponent
```

ModAPI interface giving access to resource distributor

## Events

|Member|Description|
|---|---|
|[OnPowerGenerationChanged](VRage.Game.ModAPI.IMyResourceDistributorComponent@OnPowerGenerationChanged)|Called when power generation status changed|

## Properties

|Member|Description|
|---|---|
|[ResourceState](VRage.Game.ModAPI.IMyResourceDistributorComponent@ResourceState)|Gets current resource state|
|[SourcesEnabled](VRage.Game.ModAPI.IMyResourceDistributorComponent@SourcesEnabled)|Gets if first found resources has enabled ResourceSource|

## Methods

|Member|Description|
|---|---|
|[MaxAvailableResourceByType(MyDefinitionId, IMyCubeGrid)](VRage.Game.ModAPI.IMyResourceDistributorComponent@MaxAvailableResourceByType)|Gets maximum resource available by resource type|
|[TotalRequiredInputByType(MyDefinitionId, IMyCubeGrid)](VRage.Game.ModAPI.IMyResourceDistributorComponent@TotalRequiredInputByType)|Gets currently needed resource by resource type|

**Inheritors:**  
* [MyResourceDistributorComponent](Sandbox.Game.EntityComponents.MyResourceDistributorComponent)

