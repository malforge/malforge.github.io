**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_AnimationTreeNodeDynamicTrack: MyObjectBuilder_AnimationTreeNodeTrack
```

Track node, playing track given from action

## Fields

|Member|Description|
|---|---|
|[DefaultAnimation](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeDynamicTrack@DefaultAnimation)||
|[AnimationName](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@AnimationName)|Name of used track (animation) in MWM file.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|
|[EdPos](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@EdPos)|Position in editor.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[EventNames](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@EventNames)|_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[EventTimes](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@EventTimes)|_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[Interpolate](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@Interpolate)|Interpolate between keyframes. If false, track will be played frame by frame.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|
|[Key](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@Key)|_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[Loop](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@Loop)|If true, animation will be looped. Default value is true.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|
|[PathToModel](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@PathToModel)|Path to MWM file.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|
|[Speed](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@Speed)|Playing speed multiplier.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|
|[SynchronizeWithLayer](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@SynchronizeWithLayer)|Synchronize time in this track with the specified layer.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_AnimationTreeNodeDynamicTrack()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeDynamicTrack@.ctor)||
|[MyObjectBuilder_AnimationTreeNodeTrack()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@.ctor)|_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|

## Methods

|Member|Description|
|---|---|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeDynamicTrack@GetChildren)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@GetChildren)|_Inherited from [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)_|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@GetChildren)|Get the child nodes of this node.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode) ˃ [MyObjectBuilder_AnimationTreeNodeTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack)

