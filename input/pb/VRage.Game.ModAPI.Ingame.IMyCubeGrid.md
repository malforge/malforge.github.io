**Assembly:** VRage.Game.dll

```csharp
public interface IMyCubeGrid: IMyEntity
```

Grid interface

## Properties

|Member|Description|
|---|---|
|[CustomName](VRage.Game.ModAPI.Ingame.IMyCubeGrid@CustomName)|Getter and setter for display name of the grid (as seen in Info terminal tab)|
|[GridSize](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridSize)|Getter of grid size in meters|
|[GridSizeEnum](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridSizeEnum)|Getter for grid size enum|
|[IsStatic](VRage.Game.ModAPI.Ingame.IMyCubeGrid@IsStatic)|Determines if the grid is static (unmoveable)|
|[LinearVelocity](VRage.Game.ModAPI.Ingame.IMyCubeGrid@LinearVelocity)|Gets linear velocity of the grid|
|[Max](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Max)|Maximum coordinates of blocks in grid|
|[Min](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Min)|Minimum coordinates of blocks in grid|
|[Speed](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Speed)|Gets speed of the grid calculated from Linear Velocity. Rounded to two decimal places.|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name `IMyEntities.TryGetEntityByName`<sub>prohibited</sub><br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|

## Methods

|Member|Description|
|---|---|
|[CubeExists(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@CubeExists)|Returns true if there is any block occupying given position|
|[GetCubeBlock(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GetCubeBlock)|Get cube block at given position|
|[GridIntegerToWorld(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridIntegerToWorld)|Converts grid coordinates to world space|
|[IsSameConstructAs(IMyCubeGrid)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@IsSameConstructAs)|Determines whether this grid is `Mechanical`<sub>prohibited</sub> connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.|
|[WorldToGridInteger(Vector3D)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@WorldToGridInteger)|Converts world coordinates to grid space cell coordinates|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|

**Implements:**  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

