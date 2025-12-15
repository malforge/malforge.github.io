**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_AnimationTreeNodeMix1D: MyObjectBuilder_AnimationTreeNode
```

Linear mixing node. Maps child nodes on 1D axis, interpolates according to parameter value.

## Fields

|Member|Description|
|---|---|
|[Children](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@Children)|Mapping children to axis. Each child has assigned its value.|
|[Circular](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@Circular)|True if the value wraps around.|
|[MaxChange](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@MaxChange)|Threshold: maximum change of variable to take sensitivity in account, if crossed, value is set immediatelly.|
|[ParameterName](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@ParameterName)|Name of parameter controlling blending inside this node.|
|[Sensitivity](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@Sensitivity)|Sensitivity to changes of parameter value. 1=immediate change, 0=no sensitivity.|
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
|[MyObjectBuilder_AnimationTreeNodeMix1D()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D@GetChildren)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[GetChildren()](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode@GetChildren)|Get the child nodes of this node.<br /><br />_Inherited from [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_AnimationTreeNode](VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode)

