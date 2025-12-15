**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_AnimationTreeNodeAdd: MyObjectBuilder_AnimationTreeNode
```

Additive node. Child nodes are base node + additive node.

## Fields

|Member|Description|
|---|---|
|[AddNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeAdd@AddNode)|Child node, additive "layer".|
|[BaseNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeAdd@BaseNode)|Child node, base "layer".|
|[ParameterName](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeAdd@ParameterName)|Name of parameter controlling blending inside this node.|
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
|[MyObjectBuilder_AnimationTreeNodeAdd()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeAdd@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeAdd@GetChildren)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@GetChildren)|Get the child nodes of this node.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)

