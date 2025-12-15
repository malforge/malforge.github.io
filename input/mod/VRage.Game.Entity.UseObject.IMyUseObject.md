**Assembly:** VRage.Game.dll

```csharp
public interface IMyUseObject
```

## Properties

|Member|Description|
|---|---|
|[ActivationMatrix](VRage.Game.Entity.UseObject.IMyUseObject@ActivationMatrix)|Matrix of object, scale represents size of object|
|[ContinuousUsage](VRage.Game.Entity.UseObject.IMyUseObject@ContinuousUsage)|When true, use will be called every frame|
|[Dummy](VRage.Game.Entity.UseObject.IMyUseObject@Dummy)||
|[InstanceID](VRage.Game.Entity.UseObject.IMyUseObject@InstanceID)|Instance ID of objects (this should mostly be unused|
|[InteractiveDistance](VRage.Game.Entity.UseObject.IMyUseObject@InteractiveDistance)|Consider object as being in interactive range only if distance from character is smaller or equal to this value|
|[Owner](VRage.Game.Entity.UseObject.IMyUseObject@Owner)||
|[PlayIndicatorSound](VRage.Game.Entity.UseObject.IMyUseObject@PlayIndicatorSound)||
|[PrimaryAction](VRage.Game.Entity.UseObject.IMyUseObject@PrimaryAction)|Main action of this use object|
|[RenderObjectID](VRage.Game.Entity.UseObject.IMyUseObject@RenderObjectID)|Render ID of objects|
|[SecondaryAction](VRage.Game.Entity.UseObject.IMyUseObject@SecondaryAction)|Secondary action of this use object|
|[ShouldUpdateTooltips](VRage.Game.Entity.UseObject.IMyUseObject@ShouldUpdateTooltips)||
|[ShowOverlay](VRage.Game.Entity.UseObject.IMyUseObject@ShowOverlay)|Show overlay (semitransparent bounding box)|
|[SupportedActions](VRage.Game.Entity.UseObject.IMyUseObject@SupportedActions)|Returns supported actions|
|[WorldMatrix](VRage.Game.Entity.UseObject.IMyUseObject@WorldMatrix)|Matrix of object, scale represents size of object|

## Methods

|Member|Description|
|---|---|
|[GetActionInfo(UseActionEnum)](VRage.Game.Entity.UseObject.IMyUseObject@GetActionInfo)|Gets action text Caller calls this method only on supported actions|
|[HandleInput()](VRage.Game.Entity.UseObject.IMyUseObject@HandleInput)||
|[OnSelectionLost()](VRage.Game.Entity.UseObject.IMyUseObject@OnSelectionLost)||
|[SetInstanceID(int)](VRage.Game.Entity.UseObject.IMyUseObject@SetInstanceID)||
|[SetRenderID(uint)](VRage.Game.Entity.UseObject.IMyUseObject@SetRenderID)||
|[Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use)|Uses object by specified action Caller calls this method only on supported actions|

**Inheritors:**  
* [MyFloatingObject](Sandbox.Game.Entities.MyFloatingObject)  
* [MyUseObjectBase](VRage.Game.Entity.UseObject.MyUseObjectBase)

