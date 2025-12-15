**Assembly:** VRage.Game.dll

```csharp
public interface IMyComponentStack
```

Describes component stack of the block

## Events

|Member|Description|
|---|---|
|[IntegrityChanged](VRage.Game.ModAPI.IMyComponentStack@IntegrityChanged)|Triggers when integrity is changed|
|[IsFunctionalChanged](VRage.Game.ModAPI.IMyComponentStack@IsFunctionalChanged)|Triggers when functional state has changed|

## Properties

|Member|Description|
|---|---|
|[BuildIntegrity](VRage.Game.ModAPI.IMyComponentStack@BuildIntegrity)|Gets the build integrity of the component stack|
|[BuildRatio](VRage.Game.ModAPI.IMyComponentStack@BuildRatio)|Gets the build ration of the component stack|
|[GroupCount](VRage.Game.ModAPI.IMyComponentStack@GroupCount)|Gets count of the components in the group (stack). Use with GetComponentStackInfo to get components in the stack.|
|[Integrity](VRage.Game.ModAPI.IMyComponentStack@Integrity)|Gets the integrity of the component stack|
|[IntegrityRatio](VRage.Game.ModAPI.IMyComponentStack@IntegrityRatio)|Gets the integrity ratio of the component stack|
|[IsBuilt](VRage.Game.ModAPI.IMyComponentStack@IsBuilt)|Whether this component stack is built|
|[IsDestroyed](VRage.Game.ModAPI.IMyComponentStack@IsDestroyed)|Whether the component stack is destroyed|
|[IsFullIntegrity](VRage.Game.ModAPI.IMyComponentStack@IsFullIntegrity)|Whether the component stack is at full integrity|
|[IsFullyDismounted](VRage.Game.ModAPI.IMyComponentStack@IsFullyDismounted)|Whether the component stack is fully dismounted|
|[IsFunctional](VRage.Game.ModAPI.IMyComponentStack@IsFunctional)|Whether this component stack is in functional state|
|[MaxIntegrity](VRage.Game.ModAPI.IMyComponentStack@MaxIntegrity)|Gets the max integrity of the component stack|
|[YieldLastComponent](VRage.Game.ModAPI.IMyComponentStack@YieldLastComponent)|Whether the yield last component is enabled or not.|

## Methods

|Member|Description|
|---|---|
|[GetAllMissingComponents(Dictionary<string, int>)](VRage.Game.ModAPI.IMyComponentStack@GetAllMissingComponents)|Gets missing components|
|[GetComponentStackInfo(int)](VRage.Game.ModAPI.IMyComponentStack@GetComponentStackInfo)||
|[GetMissingInfo(out int, out int)](VRage.Game.ModAPI.IMyComponentStack@GetMissingInfo)|Gets index and amount of missing component|

**Inheritors:**  
* [MyComponentStack](Sandbox.Game.Entities.MyComponentStack)

