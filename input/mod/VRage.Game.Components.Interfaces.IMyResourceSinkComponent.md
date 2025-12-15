**Assembly:** VRage.Game.dll

```csharp
public interface IMyResourceSinkComponent
```

## Properties

|Member|Description|
|---|---|
|[AcceptedResources](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@AcceptedResources)||
|[TemporaryConnectedEntity](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@TemporaryConnectedEntity)||

## Methods

|Member|Description|
|---|---|
|[CurrentInputByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@CurrentInputByType)||
|[IsPowerAvailable(MyDefinitionId, float)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@IsPowerAvailable)||
|[IsPoweredByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@IsPoweredByType)||
|[MaxRequiredInputByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@MaxRequiredInputByType)||
|[RequiredInputByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@RequiredInputByType)||
|[SetInputFromDistributor(MyDefinitionId, float, bool, bool)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetInputFromDistributor)||
|[SetMaxRequiredInputByType(MyDefinitionId, float)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetMaxRequiredInputByType)||
|[SetRequiredInputByType(MyDefinitionId, float)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetRequiredInputByType)||
|[SetRequiredInputFuncByType(MyDefinitionId, Func<float>)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetRequiredInputFuncByType)|Change the required input function (callback) for given type of resource. It does not call it immediately to update required input value.|
|[SuppliedRatioByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SuppliedRatioByType)||

**Inheritors:**  
* [MyResourceSinkComponent](Sandbox.Game.EntityComponents.MyResourceSinkComponent)  
* [MyResourceSinkComponentBase](VRage.Game.Components.MyResourceSinkComponentBase)

