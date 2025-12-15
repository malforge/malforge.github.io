**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_AnimationTreeNodeSetter: MyObjectBuilder_AnimationTreeNode
```

Setter node, storing information about timed variable setting.

## Fields

|Member|Description|
|---|---|
|[Child](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@Child)|Link to the child node.|
|[ResetValue](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@ResetValue)|Value that is set to animation storage once we leave current animation state.|
|[ResetValueEnabled](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@ResetValueEnabled)|When the, the automatic resetting is enabled.|
|[Time](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@Time)|Local animation time when the value should be set.|
|[Value](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@Value)|Value that is set to animation storage once time spent in the node exceeds specified time (MyAnimationTreeNodeSetter.Time).|
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
|[MyObjectBuilder_AnimationTreeNodeSetter()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter@GetChildren)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@GetChildren)|Get the child nodes of this node.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)

