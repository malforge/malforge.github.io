**Assembly:** VRage.Game.dll

```csharp
public interface IMySlimBlock: IMySlimBlock, IMyDestroyableObject, IMyDecalProxy
```

Basic block interface (Mod api interface)

## Properties

|Member|Description|
|---|---|
|[BlockDefinition](VRage.Game.ModAPI.IMySlimBlock@BlockDefinition)|The blocks definition (cast to MyCubeBlockDefinition)|
|[BlockGeneralDamageModifier](VRage.Game.ModAPI.IMySlimBlock@BlockGeneralDamageModifier)|Allows you to get or set the damage modifier of a block.|
|[BuiltBy](VRage.Game.ModAPI.IMySlimBlock@BuiltBy)|Identity ID of the builder of this block.|
|[ComponentStack](VRage.Game.ModAPI.IMySlimBlock@ComponentStack)|Gets the component stack of the block|
|[CubeGrid](VRage.Game.ModAPI.IMySlimBlock@CubeGrid)|Gets the grid the slimblock is on|
|[Dithering](VRage.Game.ModAPI.IMySlimBlock@Dithering)|Sets the transparency of the block.|
|[FatBlock](VRage.Game.ModAPI.IMySlimBlock@FatBlock)|Gets the fatblock if there is one|
|[IsMovedBySplit](VRage.Game.ModAPI.IMySlimBlock@IsMovedBySplit)|Gets if the block is in process of being moved from one grid to the other. Happens when grid splits to two.|
|[Max](VRage.Game.ModAPI.IMySlimBlock@Max)|Largest part of block|
|[Min](VRage.Game.ModAPI.IMySlimBlock@Min)|Min position in the grid|
|[Orientation](VRage.Game.ModAPI.IMySlimBlock@Orientation)|Blocks orientation|
|[AccumulatedDamage](VRage.Game.ModAPI.Ingame.IMySlimBlock@AccumulatedDamage)|Current accumlated damage, pending application<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[BlockDefinition](VRage.Game.ModAPI.Ingame.IMySlimBlock@BlockDefinition)|Block definition ID<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[BuildIntegrity](VRage.Game.ModAPI.Ingame.IMySlimBlock@BuildIntegrity)|Build integrity (of components)<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[BuildLevelRatio](VRage.Game.ModAPI.Ingame.IMySlimBlock@BuildLevelRatio)|Ratio of BuildIntegrity and MaxIntegrity<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[ColorMaskHSV](VRage.Game.ModAPI.Ingame.IMySlimBlock@ColorMaskHSV)|Gets the color of the block<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[CubeGrid](VRage.Game.ModAPI.Ingame.IMySlimBlock@CubeGrid)|Gets the grid the slimblock is on<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[CurrentDamage](VRage.Game.ModAPI.Ingame.IMySlimBlock@CurrentDamage)|BuildIntegrity - Integrity<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[DamageRatio](VRage.Game.ModAPI.Ingame.IMySlimBlock@DamageRatio)|_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[FatBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock@FatBlock)|Gets the fatblock if there is one<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[HasDeformation](VRage.Game.ModAPI.Ingame.IMySlimBlock@HasDeformation)|If this block is deformed (bones deformed)<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[Integrity](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@Integrity)|Gets the integrity (health) of the object<br /><br />_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[IsDestroyed](VRage.Game.ModAPI.Ingame.IMySlimBlock@IsDestroyed)|Gets if component stack is empty<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[IsFullIntegrity](VRage.Game.ModAPI.Ingame.IMySlimBlock@IsFullIntegrity)|Integrity is at maximum<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[IsFullyDismounted](VRage.Game.ModAPI.Ingame.IMySlimBlock@IsFullyDismounted)|Gets if component stack is empty<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[Mass](VRage.Game.ModAPI.Ingame.IMySlimBlock@Mass)|Block mass<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[MaxDeformation](VRage.Game.ModAPI.Ingame.IMySlimBlock@MaxDeformation)|Maximum deformation of block<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[MaxIntegrity](VRage.Game.ModAPI.Ingame.IMySlimBlock@MaxIntegrity)|The maximum integrity of block<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[OwnerId](VRage.Game.ModAPI.Ingame.IMySlimBlock@OwnerId)|Fatblock owner, if present; otherwise grid owner<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[Position](VRage.Game.ModAPI.Ingame.IMySlimBlock@Position)|Grid relative position of block<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[ShowParts](VRage.Game.ModAPI.Ingame.IMySlimBlock@ShowParts)|Gets if sub parts are shown<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[SkinSubtypeId](VRage.Game.ModAPI.Ingame.IMySlimBlock@SkinSubtypeId)|Gets the skin of the block<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[StockpileAllocated](VRage.Game.ModAPI.Ingame.IMySlimBlock@StockpileAllocated)|A component stockpile has been allocated<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[StockpileEmpty](VRage.Game.ModAPI.Ingame.IMySlimBlock@StockpileEmpty)|The component stockpile is empty (no build components)<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[UseDamageSystem](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@UseDamageSystem)|When set to true, it should use MyDamageSystem damage routing.<br /><br />_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[Neighbours](VRage.Game.ModAPI.IMySlimBlock@Neighbours)|_**Obsolete:** Allocates memory, Use GetNeighbours function_<br /><br />OBSOLETE: allocates memory use GetNeighbours function. The blocks that neighbour this block|

## Methods

|Member|Description|
|---|---|
|[AddNeighbours()](VRage.Game.ModAPI.IMySlimBlock@AddNeighbours)|Calls function that adds neighbours to block|
|[ApplyAccumulatedDamage(bool)](VRage.Game.ModAPI.IMySlimBlock@ApplyAccumulatedDamage)|When damage is less than threshold, applies not|
|[CalculateCurrentModel(out Matrix)](VRage.Game.ModAPI.IMySlimBlock@CalculateCurrentModel)|Get current model for block. When block is not functional, it would return current construction model|
|[CanContinueBuild(IMyInventory)](VRage.Game.ModAPI.IMySlimBlock@CanContinueBuild)|Can we continue to weld this block?|
|[ClearConstructionStockpile(IMyInventory)](VRage.Game.ModAPI.IMySlimBlock@ClearConstructionStockpile)|Clears out the construction stockpile and moves the components into a destination inventory|
|[ComputeScaledCenter(out Vector3D)](VRage.Game.ModAPI.IMySlimBlock@ComputeScaledCenter)|Gets the block center as a Vector3D, relative to grid WorldMatrix|
|[ComputeScaledHalfExtents(out Vector3)](VRage.Game.ModAPI.IMySlimBlock@ComputeScaledHalfExtents)|Gets the half extents for the block|
|[ComputeWorldCenter(out Vector3D)](VRage.Game.ModAPI.IMySlimBlock@ComputeWorldCenter)|Gets the world position for the center of the block|
|[DecreaseMountLevel(float, IMyInventory, bool)](VRage.Game.ModAPI.IMySlimBlock@DecreaseMountLevel)|Decreases the build level of a block|
|[FixBones(float, float)](VRage.Game.ModAPI.IMySlimBlock@FixBones)|Repair block deformation|
|[FullyDismount(IMyInventory)](VRage.Game.ModAPI.IMySlimBlock@FullyDismount)|Reset built level to 0|
|[GetColorMask()](VRage.Game.ModAPI.IMySlimBlock@GetColorMask)|Gets block color|
|[GetConstructionStockpileItemAmount(MyDefinitionId)](VRage.Game.ModAPI.IMySlimBlock@GetConstructionStockpileItemAmount)|Get the amount of items in the construction stockpile|
|[GetNeighbours(ICollection<IMySlimBlock>)](VRage.Game.ModAPI.IMySlimBlock@GetNeighbours)|The blocks that neighbour this block. Doesn't allocate memory|
|[GetObjectBuilder(bool)](VRage.Game.ModAPI.IMySlimBlock@GetObjectBuilder)|Gets the object builder for the slimblock|
|[GetWorldBoundingBox(out BoundingBoxD, bool)](VRage.Game.ModAPI.IMySlimBlock@GetWorldBoundingBox)|The AABB of this block|
|[IncreaseMountLevel(float, long, IMyInventory, float, bool, MyOwnershipShareModeEnum)](VRage.Game.ModAPI.IMySlimBlock@IncreaseMountLevel)|Increases the build level of a block|
|[InitOrientation(ref Vector3I, ref Vector3I)](VRage.Game.ModAPI.IMySlimBlock@InitOrientation)|Sets orientation of block|
|[InitOrientation(Direction, Direction)](VRage.Game.ModAPI.IMySlimBlock@InitOrientation)||
|[InitOrientation(MyBlockOrientation)](VRage.Game.ModAPI.IMySlimBlock@InitOrientation)|Sets orientation of block|
|[MoveItemsFromConstructionStockpile(IMyInventory, MyItemFlags)](VRage.Game.ModAPI.IMySlimBlock@MoveItemsFromConstructionStockpile)|Transfer construction components from inventory to stockpile|
|[MoveItemsToConstructionStockpile(IMyInventory)](VRage.Game.ModAPI.IMySlimBlock@MoveItemsToConstructionStockpile)|Move items missing from an inventory into the construction stockpile|
|[PlayConstructionSound(MyIntegrityChangeEnum, bool)](VRage.Game.ModAPI.IMySlimBlock@PlayConstructionSound)|Play the construction sound associated with the integrity change|
|[RemoveNeighbours()](VRage.Game.ModAPI.IMySlimBlock@RemoveNeighbours)|Removes block neighbours|
|[SetToConstructionSite()](VRage.Game.ModAPI.IMySlimBlock@SetToConstructionSite)|Resets welded integrity to minimal value|
|[SpawnConstructionStockpile()](VRage.Game.ModAPI.IMySlimBlock@SpawnConstructionStockpile)|Spawn contents of construction stockpile|
|[SpawnFirstItemInConstructionStockpile()](VRage.Game.ModAPI.IMySlimBlock@SpawnFirstItemInConstructionStockpile)|Adds the first component to the stockpile|
|[UpdateVisual()](VRage.Game.ModAPI.IMySlimBlock@UpdateVisual)|Drops visual cache. May fix some render problems.|
|[AddDecals(ref MyHitInfo, MyStringHash, Vector3, object, IMyDecalHandler, MyStringHash, MyStringHash, bool, MyDecalFlags, int, List<uint>)](VRage.Game.ModAPI.Interfaces.IMyDecalProxy@AddDecals)|Called from Sandbox.Game.MyDecals<br /><br />_Inherited from [IMyDecalProxy](VRage.Game.ModAPI.Interfaces.IMyDecalProxy)_|
|[DoDamage(float, MyStringHash, bool, MyHitInfo?, long, long, bool, MyStringHash?)](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@DoDamage)|Applies damage to an object<br /><br />_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[GetMissingComponents(Dictionary<string, int>)](VRage.Game.ModAPI.Ingame.IMySlimBlock@GetMissingComponents)|Gets the list of missing components for this block<br /><br />_Inherited from [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)_|
|[OnDestroy()](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@OnDestroy)|_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[GetCopyObjectBuilder()](VRage.Game.ModAPI.IMySlimBlock@GetCopyObjectBuilder)|_**Obsolete:** GetCopyObjectBuilder() is deprecated. Call GetObjectBuilder(bool) and pass 'true'._|

**Implements:**  
* [IMyDecalProxy](VRage.Game.ModAPI.Interfaces.IMyDecalProxy)  
* [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)  
* [IMySlimBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock)

