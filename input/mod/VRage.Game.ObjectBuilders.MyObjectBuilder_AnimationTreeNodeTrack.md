**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_AnimationTreeNodeTrack: MyObjectBuilder_AnimationTreeNode
```

Track node, storing information about track and playing settings.

## Fields

|Member|Description|
|---|---|
|[AnimationName](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@AnimationName)|Name of used track (animation) in MWM file.|
|[Interpolate](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@Interpolate)|Interpolate between keyframes. If false, track will be played frame by frame.|
|[Loop](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@Loop)|If true, animation will be looped. Default value is true.|
|[PathToModel](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@PathToModel)|Path to MWM file.|
|[Speed](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@Speed)|Playing speed multiplier.|
|[SynchronizeWithLayer](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@SynchronizeWithLayer)|Synchronize time in this track with the specified layer.|
|[EdPos](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@EdPos)|Position in editor.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[EventNames](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@EventNames)|_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[EventTimes](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@EventTimes)|_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[Key](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@Key)|_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_AnimationTreeNodeTrack()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack@GetChildren)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@GetChildren)|Get the child nodes of this node.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)

**Inheritors:**  
* [MyObjectBuilder_AnimationTreeNodeDynamicTrack](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeDynamicTrack)

