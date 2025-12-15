**Assembly:** VRage.Game.dll

```csharp
public interface IMyCharacter: IMyEntity, IMyEntity, IMyControllableEntity, IMyCameraController, IMyDestroyableObject, IMyDecalProxy
```

Describes character (mods interface)

## Events

|Member|Description|
|---|---|
|[CharacterDied](VRage.Game.ModAPI.IMyCharacter@CharacterDied)|Event triggered when character dies|
|[MovementStateChanged](VRage.Game.ModAPI.IMyCharacter@MovementStateChanged)|Called when the movement state changes|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMovementStateChanged](VRage.Game.ModAPI.IMyCharacter@OnMovementStateChanged)|_**Obsolete:** OnMovementStateChanged is deprecated, use MovementStateChanged_|

## Properties

|Member|Description|
|---|---|
|[AimedPoint](VRage.Game.ModAPI.IMyCharacter@AimedPoint)|Gets or, for non-player controlled characters, sets the aimed point direction.|
|[BaseMass](VRage.Game.ModAPI.IMyCharacter@BaseMass)|Gets the base mass of the character|
|[CanSprint](VRage.Game.ModAPI.IMyCharacter@CanSprint)|Gets/Sets if character can sprint|
|[CharacterGeneralDamageModifier](VRage.Game.ModAPI.IMyCharacter@CharacterGeneralDamageModifier)|Allows you to get or set the damage modifier of a character.|
|[CurrentMass](VRage.Game.ModAPI.IMyCharacter@CurrentMass)|Gets the entire mass of the character, including inventory|
|[CurrentMovementState](VRage.Game.ModAPI.IMyCharacter@CurrentMovementState)|Gets the character's current movement state.|
|[Definition](VRage.Game.ModAPI.IMyCharacter@Definition)|The character definition. Cast to MyCharacterDefinition.|
|[EnvironmentOxygenLevel](VRage.Game.ModAPI.IMyCharacter@EnvironmentOxygenLevel)|Gets the amount of oxygen in the surrounding environment|
|[EquippedTool](VRage.Game.ModAPI.IMyCharacter@EquippedTool)|Gets currently equipped tool (IMyHandheldGunObject)|
|[IsBot](VRage.Game.ModAPI.IMyCharacter@IsBot)|Returns true if this character is an AI character, otherwise false.|
|[IsDead](VRage.Game.ModAPI.IMyCharacter@IsDead)|Returns true if this character is dead|
|[IsPlayer](VRage.Game.ModAPI.IMyCharacter@IsPlayer)|Returns true if this character is a player character, otherwise false.|
|[OxygenLevel](VRage.Game.ModAPI.IMyCharacter@OxygenLevel)|Gets the amount of oxygen at the character location from air pressure system (grids with airtightness)|
|[PreviousMovementState](VRage.Game.ModAPI.IMyCharacter@PreviousMovementState)|Gets the character's previous movement state.|
|[SuitEnergyLevel](VRage.Game.ModAPI.IMyCharacter@SuitEnergyLevel)|Returns the amount of energy the suit has, values will range between 0 and 1, where 0 is no charge and 1 is full charge.|
|[UsingEntity](VRage.Game.ModAPI.IMyCharacter@UsingEntity)|Gets currently used entity by character (cockpit, cryo etc.)|
|[AllowCubeBuilding](VRage.Game.ModAPI.Interfaces.IMyCameraController@AllowCubeBuilding)|Gets if player block building enabled<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[CanSwitchLandingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@CanSwitchLandingGears)|Gets if entity can switch landing gears<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[ControllerInfo](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ControllerInfo)|Gets information about who controls this Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DebugAsyncLoading](VRage.ModAPI.IMyEntity@DebugAsyncLoading)|Used for internal usage. Modders should not use it. Will be eventually removed<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.ModAPI.IMyEntity@DisplayName)|Gets or sets user friendly name of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EnabledDamping](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledDamping)|Gets if Damping enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledHelmet](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledHelmet)|Gets if helmet is opened<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLeadingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLeadingGears)|Gets if at least one leading gear is enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLights](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLights)|Gets if lights are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledReactors](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledReactors)|Gets if grid is powered<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledThrusts](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledThrusts)|Gets if thrusts are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnableFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@EnableFirstPersonView)|Gets or set if player can use first person view<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyCameraController@Entity)|Gets Entity to which it is attached<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Entity)|Gets information which entity is being controlled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.ModAPI.IMyEntity@EntityId)|Uniq id of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[FastCastShadowResolve](VRage.ModAPI.IMyEntity@FastCastShadowResolve)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Flags](VRage.ModAPI.IMyEntity@Flags)|Gets or set some behavior of entity. [EntityFlags](VRage.ModAPI.EntityFlags)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyCameraController@ForceFirstPersonCamera)|Gets or sets if player can use only first person view<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ForceFirstPersonCamera)|Gets or sets if camera should be first person<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[GameLogic](VRage.ModAPI.IMyEntity@GameLogic)|Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Hierarchy](VRage.ModAPI.IMyEntity@Hierarchy)|Gets or sets Hierarchy component<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InScene](VRage.ModAPI.IMyEntity@InScene)|Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Integrity](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@Integrity)|Gets the integrity (health) of the object<br /><br />_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[InvalidateOnMove](VRage.ModAPI.IMyEntity@InvalidateOnMove)|Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsAutopilotControlled](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@IsAutopilotControlled)|Gets whether the entity is controller by autopilot<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[IsInFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@IsInFirstPersonView)|Gets or sets if the current camera view is first person.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LastMotionIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastMotionIndicator)|Gets last motion indicator. User input W/A/S/D Space/C<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LastRotationIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastRotationIndicator)|Gets last rotation indicator. Z used for RollIndicator<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Model](VRage.ModAPI.IMyEntity@Model)|Gets model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ModelCollision](VRage.ModAPI.IMyEntity@ModelCollision)|Gets collision model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.ModAPI.IMyEntity@Name)|Uniq name of entity. Can be used to find entity by name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NearFlag](VRage.ModAPI.IMyEntity@NearFlag)|Gets or sets flag [Near](VRage.ModAPI.EntityFlags@Near)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDraw](VRage.ModAPI.IMyEntity@NeedsDraw)|Gets or sets flag [NeedsDraw](VRage.ModAPI.EntityFlags@NeedsDraw)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDrawFromParent](VRage.ModAPI.IMyEntity@NeedsDrawFromParent)|Gets or sets flag [NeedsDrawFromParent](VRage.ModAPI.EntityFlags@NeedsDrawFromParent)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsResolveCastShadow](VRage.ModAPI.IMyEntity@NeedsResolveCastShadow)|Gets or sets flag [NeedsResolveCastShadow](VRage.ModAPI.EntityFlags@NeedsResolveCastShadow)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate)|Gets or sets how often the entity should be updated.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsWorldMatrix](VRage.ModAPI.IMyEntity@NeedsWorldMatrix)|Gets or sets if [WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix) should be calculated when parent WorldMatrix is changed.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Parent](VRage.ModAPI.IMyEntity@Parent)|Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PersistentFlags](VRage.ModAPI.IMyEntity@PersistentFlags)|Gets or sets persistent flags that are used in rendering.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Physics](VRage.ModAPI.IMyEntity@Physics)|Gets or sets physics for object<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PositionComp](VRage.ModAPI.IMyEntity@PositionComp)|Gets or sets position provider logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PrimaryLookaround](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PrimaryLookaround)|When false, blocks 3rd view look around<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningDistance](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningDistance)|Allows you to set a custom max distance which relative dampening to another entity will remain active.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningTarget](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningTarget)|Allows you to get or set the relative dampening entity.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Render](VRage.ModAPI.IMyEntity@Render)|Gets or sets render logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Save](VRage.ModAPI.IMyEntity@Save)|Gets or sets [Save](VRage.ModAPI.EntityFlags@Save) . Entity won't be saved if [Save](VRage.ModAPI.IMyEntity@Save) is false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShadowBoxLod](VRage.ModAPI.IMyEntity@ShadowBoxLod)|Gets or sets flag [ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SkipIfTooSmall](VRage.ModAPI.IMyEntity@SkipIfTooSmall)|Gets or sets flag [SkipIfTooSmall](VRage.ModAPI.EntityFlags@SkipIfTooSmall)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[StopPhysicsActivation](VRage.ModAPI.IMyEntity@StopPhysicsActivation)|_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Storage](VRage.ModAPI.IMyEntity@Storage)|Custom storage for mods. Shared with all mods.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Synchronized](VRage.ModAPI.IMyEntity@Synchronized)|Gets or sets if the entity should be synced.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SyncObject](VRage.ModAPI.IMyEntity@SyncObject)|Gets SyncObject used for synchronizing data over network with<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Transparent](VRage.ModAPI.IMyEntity@Transparent)|Gets or sets [Transparency](VRage.Game.Components.MyRenderComponentBase@Transparency) . When setting true entity would be 25% transparent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UseDamageSystem](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@UseDamageSystem)|When set to true, it should use MyDamageSystem damage routing.<br /><br />_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[Visible](VRage.ModAPI.IMyEntity@Visible)|Gets or sets flag [Visible](VRage.Game.Components.MyRenderComponentBase@Visible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix)|Gets or sets world matrix.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixInvScaled](VRage.ModAPI.IMyEntity@WorldMatrixInvScaled)|Get scaled, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) , but not normalized<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsCCDForProjectiles](VRage.ModAPI.IMyEntity@IsCCDForProjectiles)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.ModAPI.IMyEntity@LocationForHudMarker)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Methods

|Member|Description|
|---|---|
|[GetOutsideTemperature()](VRage.Game.ModAPI.IMyCharacter@GetOutsideTemperature)|Returns outside temperature around character. If character is in presurrized/oxygen environment, then the temperature is always friendly.|
|[GetSuitGasFillLevel(MyDefinitionId)](VRage.Game.ModAPI.IMyCharacter@GetSuitGasFillLevel)|Returns the amount of gas left in the suit, values will range between 0 and 1, where 0 is no gas and 1 is full gas.|
|[Kill(object)](VRage.Game.ModAPI.IMyCharacter@Kill)|Kills the character|
|[SetCharacterSpeedDebuff(float)](VRage.Game.ModAPI.IMyCharacter@SetCharacterSpeedDebuff)|Sets character speed debuf|
|[TriggerCharacterAnimationEvent(string, bool)](VRage.Game.ModAPI.IMyCharacter@TriggerCharacterAnimationEvent)|Trigger animation event in the new animation system. If there is a transition leading from current animation state having same name as this event, animation state machine will change state accordingly. If not, nothing happens.|
|[AddDecals(ref MyHitInfo, MyStringHash, Vector3, object, IMyDecalHandler, MyStringHash, MyStringHash, bool, MyDecalFlags, int, List<uint>)](VRage.Game.ModAPI.Interfaces.IMyDecalProxy@AddDecals)|Called from Sandbox.Game.MyDecals<br /><br />_Inherited from [IMyDecalProxy](VRage.Game.ModAPI.Interfaces.IMyDecalProxy)_|
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ControlCamera(MyCamera)](VRage.Game.ModAPI.Interfaces.IMyCameraController@ControlCamera)|Change camera properties now. Communication: from controller to camera.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Crouch()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Crouch)|Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DebugDraw()](VRage.ModAPI.IMyEntity@DebugDraw)|Calls debug draw of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDrawInvalidTriangles()](VRage.ModAPI.IMyEntity@DebugDrawInvalidTriangles)|Calls special debug draw, that highlighting invalid triangles in model<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Delete()](VRage.ModAPI.IMyEntity@Delete)|Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](VRage.ModAPI.IMyEntity@Close) method.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Die()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Die)|Makes character dead.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DoDamage(float, MyStringHash, bool, MyHitInfo?, long, long, bool, MyStringHash?)](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@DoDamage)|Applies damage to an object<br /><br />_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[DoOverlapSphereTest(float, Vector3D)](VRage.ModAPI.IMyEntity@DoOverlapSphereTest)|Checks if intersects Works only with [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Down()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Down)|Move direction : down. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DrawHud(IMyCameraController, long)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@DrawHud)|Updates hud logic, connected to entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnableColorMaskForSubparts(bool)](VRage.ModAPI.IMyEntity@EnableColorMaskForSubparts)|Allows subparts have different color than their parent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDiffuseColor()](VRage.ModAPI.IMyEntity@GetDiffuseColor)|Gets render diffuse color<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndBoundingSphere)|Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndPosition)|Distance from camera to position of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetFriendlyName()](VRage.ModAPI.IMyEntity@GetFriendlyName)|Not used. Actually not a friendly name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetHeadMatrix(bool, bool, bool, bool)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@GetHeadMatrix)|Gets head of character that controls this<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntity@GetIntersectionWithAABB)|Return true if object intersects specified bounding box.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.ModAPI.IMyEntity@GetIntersectionWithLine)|Get intersection of model with provided line<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.ModAPI.IMyEntity@GetIntersectionWithLineAndBoundingSphere)|Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntity@GetIntersectionWithSphere)|Return true if object intersects specified sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory()](VRage.ModAPI.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory(int)](VRage.ModAPI.IMyEntity@GetInventory)|Search for inventory component with matching index.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)|Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetObjectBuilder(bool)](VRage.ModAPI.IMyEntity@GetObjectBuilder)|Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetOverridingFocusMatrix()](VRage.Game.ModAPI.Interfaces.IMyCameraController@GetOverridingFocusMatrix)|Transformation that should be used for target selection while focusing<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)|Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetSubpart(string)](VRage.ModAPI.IMyEntity@GetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTopMostParent(Type)](VRage.ModAPI.IMyEntity@GetTopMostParent)|Gets top most [Parent](VRage.ModAPI.IMyEntity@Parent) of specified type. Top most is entity that doesn't have parent (of specified type)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.ModAPI.IMyEntity@GetTrianglesIntersectingSphere)|Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix)|Get normalized, inverted world matrix. Same as [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[HandlePickUp()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandlePickUp)|Does nothing.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[HandleUse()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandleUse)|Used to send "use" commands to camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[IsVisible()](VRage.ModAPI.IMyEntity@IsVisible)|Gets or result of function [IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible) . Function inside check for [IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Jump(Vector3)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Jump)|Character jump. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotate(Vector3, Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotate)|Defines user input. Call [MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped) on user input finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped)|Should be called when input is finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[OnAddedToScene(object)](VRage.ModAPI.IMyEntity@OnAddedToScene)|Adds entity to scene: init updates, render physics<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnAssumeControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnAssumeControl)|Called when it is setted as new main camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[OnDestroy()](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@OnDestroy)|_Inherited from [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)_|
|[OnReleaseControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnReleaseControl)|Called when new camera controller setted, and this was main camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[OnRemovedFromScene(object)](VRage.ModAPI.IMyEntity@OnRemovedFromScene)|Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PickUp()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUp)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUpContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUpContinues)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Rotate(Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyCameraController@Rotate)|Rotate camera controller.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[RotateStopped()](VRage.Game.ModAPI.Interfaces.IMyCameraController@RotateStopped)|Rotation of camera controller stopped.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[SetColorMaskForSubparts(Vector3)](VRage.ModAPI.IMyEntity@SetColorMaskForSubparts)|Sets subparts custom col<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissiveParts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissiveParts)|Sets the emissive value of a specific emissive material on entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissivePartsForSubparts)|Sets the emissive value of a specific emissive material on all entity subparts.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetLocalMatrix(Matrix, object)](VRage.ModAPI.IMyEntity@SetLocalMatrix)|Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)|Set WorldMatrix's [Translation](VRageMath.MatrixD@Translation) . Moves entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp<br />MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetWorldMatrix(MatrixD, object)](VRage.ModAPI.IMyEntity@SetWorldMatrix)|Sets world matrix of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShowInventory()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowInventory)|Shows inventory gui of controlled Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ShowRemoteAccessMenu()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowRemoteAccessMenu)|Shows remote access menu<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ShowTerminal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowTerminal)|Shows terminal gui<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchDamping()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchDamping)|Switches damping state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchHandbrake()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHandbrake)|Switches handbrake state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchHelmet()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHelmet)|Switches helmet open/closed state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchLandingGears()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLandingGears)|Switches landing gears state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchLights()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLights)|Switches lights state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchReactors()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactors)|Switches reactors state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchReactorsLocal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactorsLocal)|Switches handbrake state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchThrusts()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchThrusts)|Turns on jetpack on character<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchWalk()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchWalk)|Switch between walk / run mode. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Teleport(MatrixD, object, bool)](VRage.ModAPI.IMyEntity@Teleport)|When moving entity over large distances or when entity has children, using this method preferred over [SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.ModAPI.IMyEntity@TryGetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Up()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Up)|Move direction : up. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UpdateGamePruningStructure()](VRage.ModAPI.IMyEntity@UpdateGamePruningStructure)|Update position of entity in MyGamePruningStructure. Calls:```csharp<br />MyGamePruningStructure.Move(this)<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Use()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Use)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UseContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@UseContinues)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

**Implements:**  
* [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)  
* [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)  
* [IMyDecalProxy](VRage.Game.ModAPI.Interfaces.IMyDecalProxy)  
* [IMyDestroyableObject](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject)  
* [IMyEntity](VRage.ModAPI.IMyEntity)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

