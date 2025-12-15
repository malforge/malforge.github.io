**Assembly:** VRage.Game.dll

```csharp
public abstract class MyUseObjectBase: IMyUseObject
```

## Properties

|Member|Description|
|---|---|
|[ActivationMatrix](VRage.Game.Entity.UseObject.MyUseObjectBase@ActivationMatrix)||
|[ContinuousUsage](VRage.Game.Entity.UseObject.MyUseObjectBase@ContinuousUsage)||
|[Dummy](VRage.Game.Entity.UseObject.MyUseObjectBase@Dummy)||
|[InstanceID](VRage.Game.Entity.UseObject.MyUseObjectBase@InstanceID)||
|[InteractiveDistance](VRage.Game.Entity.UseObject.MyUseObjectBase@InteractiveDistance)||
|[Owner](VRage.Game.Entity.UseObject.MyUseObjectBase@Owner)||
|[PlayIndicatorSound](VRage.Game.Entity.UseObject.MyUseObjectBase@PlayIndicatorSound)||
|[PrimaryAction](VRage.Game.Entity.UseObject.MyUseObjectBase@PrimaryAction)||
|[RenderObjectID](VRage.Game.Entity.UseObject.MyUseObjectBase@RenderObjectID)||
|[SecondaryAction](VRage.Game.Entity.UseObject.MyUseObjectBase@SecondaryAction)||
|[ShouldUpdateTooltips](VRage.Game.Entity.UseObject.MyUseObjectBase@ShouldUpdateTooltips)||
|[ShowOverlay](VRage.Game.Entity.UseObject.MyUseObjectBase@ShowOverlay)||
|[SupportedActions](VRage.Game.Entity.UseObject.MyUseObjectBase@SupportedActions)||
|[WorldMatrix](VRage.Game.Entity.UseObject.MyUseObjectBase@WorldMatrix)||
|[ActivationMatrix](VRage.Game.Entity.UseObject.IMyUseObject@ActivationMatrix)|Matrix of object, scale represents size of object<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[ContinuousUsage](VRage.Game.Entity.UseObject.IMyUseObject@ContinuousUsage)|When true, use will be called every frame<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[Dummy](VRage.Game.Entity.UseObject.IMyUseObject@Dummy)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[InstanceID](VRage.Game.Entity.UseObject.IMyUseObject@InstanceID)|Instance ID of objects (this should mostly be unused<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[InteractiveDistance](VRage.Game.Entity.UseObject.IMyUseObject@InteractiveDistance)|Consider object as being in interactive range only if distance from character is smaller or equal to this value<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[Owner](VRage.Game.Entity.UseObject.IMyUseObject@Owner)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[PlayIndicatorSound](VRage.Game.Entity.UseObject.IMyUseObject@PlayIndicatorSound)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[PrimaryAction](VRage.Game.Entity.UseObject.IMyUseObject@PrimaryAction)|Main action of this use object<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[RenderObjectID](VRage.Game.Entity.UseObject.IMyUseObject@RenderObjectID)|Render ID of objects<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[SecondaryAction](VRage.Game.Entity.UseObject.IMyUseObject@SecondaryAction)|Secondary action of this use object<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[ShouldUpdateTooltips](VRage.Game.Entity.UseObject.IMyUseObject@ShouldUpdateTooltips)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[ShowOverlay](VRage.Game.Entity.UseObject.IMyUseObject@ShowOverlay)|Show overlay (semitransparent bounding box)<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[SupportedActions](VRage.Game.Entity.UseObject.IMyUseObject@SupportedActions)|Returns supported actions<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[WorldMatrix](VRage.Game.Entity.UseObject.IMyUseObject@WorldMatrix)|Matrix of object, scale represents size of object<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|

## Methods

|Member|Description|
|---|---|
|[GetActionInfo(UseActionEnum)](VRage.Game.Entity.UseObject.MyUseObjectBase@GetActionInfo)||
|[HandleInput()](VRage.Game.Entity.UseObject.MyUseObjectBase@HandleInput)||
|[OnSelectionLost()](VRage.Game.Entity.UseObject.MyUseObjectBase@OnSelectionLost)||
|[SetInstanceID(int)](VRage.Game.Entity.UseObject.MyUseObjectBase@SetInstanceID)||
|[SetRenderID(uint)](VRage.Game.Entity.UseObject.MyUseObjectBase@SetRenderID)||
|[Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.MyUseObjectBase@Use)||
|[GetActionInfo(UseActionEnum)](VRage.Game.Entity.UseObject.IMyUseObject@GetActionInfo)|Gets action text Caller calls this method only on supported actions<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[HandleInput()](VRage.Game.Entity.UseObject.IMyUseObject@HandleInput)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[OnSelectionLost()](VRage.Game.Entity.UseObject.IMyUseObject@OnSelectionLost)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[SetInstanceID(int)](VRage.Game.Entity.UseObject.IMyUseObject@SetInstanceID)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[SetRenderID(uint)](VRage.Game.Entity.UseObject.IMyUseObject@SetRenderID)|_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|
|[Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use)|Uses object by specified action Caller calls this method only on supported actions<br /><br />_Inherited from [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)_|

**Implements:**  
* [IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)

