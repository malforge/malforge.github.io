**Assembly:** Sandbox.Game.dll

```csharp
public class MyComponentStack: IMyComponentStack
```

## Fields

|Member|Description|
|---|---|
|[static MOUNT_THRESHOLD](Sandbox.Game.Entities.MyComponentStack@MOUNT_THRESHOLD)|Mount threshold, required because of float inaccuracy. Component that has integrity beyond this threshold is considered unmounted. The integrity of the whole stack will never fall beyond this level (unless the stack is fully dismounted)|
|[BuildIntegrityChanged](Sandbox.Game.Entities.MyComponentStack@BuildIntegrityChanged)||
|[IntegrityChanged](Sandbox.Game.Entities.MyComponentStack@IntegrityChanged)||

## Events

|Member|Description|
|---|---|
|[IsFunctionalChanged](Sandbox.Game.Entities.MyComponentStack@IsFunctionalChanged)||
|[IntegrityChanged](VRage.Game.ModAPI.IMyComponentStack@IntegrityChanged)|Triggers when integrity is changed<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IsFunctionalChanged](VRage.Game.ModAPI.IMyComponentStack@IsFunctionalChanged)|Triggers when functional state has changed<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|

## Properties

|Member|Description|
|---|---|
|[static NewBlockIntegrity](Sandbox.Game.Entities.MyComponentStack@NewBlockIntegrity)||
|[BuildIntegrity](Sandbox.Game.Entities.MyComponentStack@BuildIntegrity)||
|[BuildRatio](Sandbox.Game.Entities.MyComponentStack@BuildRatio)||
|[GroupCount](Sandbox.Game.Entities.MyComponentStack@GroupCount)||
|[Integrity](Sandbox.Game.Entities.MyComponentStack@Integrity)||
|[IntegrityRatio](Sandbox.Game.Entities.MyComponentStack@IntegrityRatio)||
|[IsBuilt](Sandbox.Game.Entities.MyComponentStack@IsBuilt)|Whether the block is built based on build-time integrity (construction state) and the final model can be shown. Uses [BuildIntegrity](Sandbox.Game.Entities.MyComponentStack@BuildIntegrity) for the check.|
|[IsDestroyed](Sandbox.Game.Entities.MyComponentStack@IsDestroyed)||
|[IsFullIntegrity](Sandbox.Game.Entities.MyComponentStack@IsFullIntegrity)||
|[IsFullyDismounted](Sandbox.Game.Entities.MyComponentStack@IsFullyDismounted)||
|[IsFunctional](Sandbox.Game.Entities.MyComponentStack@IsFunctional)|Component stack is functional when critical part is not destroyed (integrity > 0). IMPORTANT: When you change the logic beyond this property, don't forget to call CheckFunctionalState every time the functional state could have been changed! (Also, remove calls to CheckFunctionalState where no longer needed)|
|[LastChangeStamp](Sandbox.Game.Entities.MyComponentStack@LastChangeStamp)||
|[MaxIntegrity](Sandbox.Game.Entities.MyComponentStack@MaxIntegrity)||
|[YieldLastComponent](Sandbox.Game.Entities.MyComponentStack@YieldLastComponent)||
|[BuildIntegrity](VRage.Game.ModAPI.IMyComponentStack@BuildIntegrity)|Gets the build integrity of the component stack<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[BuildRatio](VRage.Game.ModAPI.IMyComponentStack@BuildRatio)|Gets the build ration of the component stack<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[GroupCount](VRage.Game.ModAPI.IMyComponentStack@GroupCount)|Gets count of the components in the group (stack). Use with GetComponentStackInfo to get components in the stack.<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[Integrity](VRage.Game.ModAPI.IMyComponentStack@Integrity)|Gets the integrity of the component stack<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IntegrityRatio](VRage.Game.ModAPI.IMyComponentStack@IntegrityRatio)|Gets the integrity ratio of the component stack<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IsBuilt](VRage.Game.ModAPI.IMyComponentStack@IsBuilt)|Whether this component stack is built<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IsDestroyed](VRage.Game.ModAPI.IMyComponentStack@IsDestroyed)|Whether the component stack is destroyed<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IsFullIntegrity](VRage.Game.ModAPI.IMyComponentStack@IsFullIntegrity)|Whether the component stack is at full integrity<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IsFullyDismounted](VRage.Game.ModAPI.IMyComponentStack@IsFullyDismounted)|Whether the component stack is fully dismounted<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[IsFunctional](VRage.Game.ModAPI.IMyComponentStack@IsFunctional)|Whether this component stack is in functional state<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[MaxIntegrity](VRage.Game.ModAPI.IMyComponentStack@MaxIntegrity)|Gets the max integrity of the component stack<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[YieldLastComponent](VRage.Game.ModAPI.IMyComponentStack@YieldLastComponent)|Whether the yield last component is enabled or not.<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|

## Constructors

|Member|Description|
|---|---|
|[MyComponentStack(MyCubeBlockDefinition, float, float)](Sandbox.Game.Entities.MyComponentStack@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static GetMountedComponents(MyComponentList, MyObjectBuilder_CubeBlock)](Sandbox.Game.Entities.MyComponentStack@GetMountedComponents)||
|[ApplyDamage(float, MyConstructionStockpile)](Sandbox.Game.Entities.MyComponentStack@ApplyDamage)|Applies damage to the component stack. The method works almost the same as dismounting, it just leaves the build level at the original value and also the parts that are put into the outputStockpile are damaged.|
|[CanContinueBuild(MyInventoryBase, MyConstructionStockpile)](Sandbox.Game.Entities.MyComponentStack@CanContinueBuild)||
|[DecreaseMountLevel(float, MyConstructionStockpile, bool)](Sandbox.Game.Entities.MyComponentStack@DecreaseMountLevel)|Dismounts component stack, dismounted items are put into output stockpile|
|[DestroyCompletely()](Sandbox.Game.Entities.MyComponentStack@DestroyCompletely)||
|[DisableLastComponentYield()](Sandbox.Game.Entities.MyComponentStack@DisableLastComponentYield)||
|[GetAllMissingComponents(Dictionary<string, int>)](Sandbox.Game.Entities.MyComponentStack@GetAllMissingComponents)||
|[GetComponentStackInfo(int)](Sandbox.Game.Entities.MyComponentStack@GetComponentStackInfo)||
|[GetGroupInfo(int)](Sandbox.Game.Entities.MyComponentStack@GetGroupInfo)||
|[GetMissingComponents(Dictionary<string, int>, MyConstructionStockpile)](Sandbox.Game.Entities.MyComponentStack@GetMissingComponents)||
|[GetMissingInfo(out int, out int)](Sandbox.Game.Entities.MyComponentStack@GetMissingInfo)||
|[IncreaseMountLevel(float, MyConstructionStockpile)](Sandbox.Game.Entities.MyComponentStack@IncreaseMountLevel)||
|[UpdateBuildIntegrityDown(float)](Sandbox.Game.Entities.MyComponentStack@UpdateBuildIntegrityDown)||
|[UpdateBuildIntegrityUp()](Sandbox.Game.Entities.MyComponentStack@UpdateBuildIntegrityUp)||
|[WillFunctionalityRise(float)](Sandbox.Game.Entities.MyComponentStack@WillFunctionalityRise)||
|[GetAllMissingComponents(Dictionary<string, int>)](VRage.Game.ModAPI.IMyComponentStack@GetAllMissingComponents)|Gets missing components<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[GetComponentStackInfo(int)](VRage.Game.ModAPI.IMyComponentStack@GetComponentStackInfo)|_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|
|[GetMissingInfo(out int, out int)](VRage.Game.ModAPI.IMyComponentStack@GetMissingInfo)|Gets index and amount of missing component<br /><br />_Inherited from [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)_|

**Implements:**  
* [IMyComponentStack](VRage.Game.ModAPI.IMyComponentStack)

