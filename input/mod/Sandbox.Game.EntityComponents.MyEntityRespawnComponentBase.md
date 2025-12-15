**Assembly:** Sandbox.Game.dll

```csharp
public abstract class MyEntityRespawnComponentBase: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase, IMyCameraController, IMyControllableEntity, IMyControllableEntity
```

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AuxiliaryContext](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@AuxiliaryContext)||
|[Entity](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@Entity)||
|[IsAutopilotControlled](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@IsAutopilotControlled)||
|[LastMotionIndicator](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@LastMotionIndicator)||
|[LastRotationIndicator](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@LastRotationIndicator)||
|[AllowCubeBuilding](VRage.Game.ModAPI.Interfaces.IMyCameraController@AllowCubeBuilding)|Gets if player block building enabled<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[AuxiliaryContext](Sandbox.Game.Entities.IMyControllableEntity@AuxiliaryContext)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CanSwitchLandingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@CanSwitchLandingGears)|Gets if entity can switch landing gears<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[ControlContext](Sandbox.Game.Entities.IMyControllableEntity@ControlContext)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ControllerInfo](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ControllerInfo)|Gets information about who controls this Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ControllerInfo](Sandbox.Game.Entities.IMyControllableEntity@ControllerInfo)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[EnabledBroadcasting](Sandbox.Game.Entities.IMyControllableEntity@EnabledBroadcasting)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[EnabledDamping](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledDamping)|Gets if Damping enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledHelmet](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledHelmet)|Gets if helmet is opened<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLeadingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLeadingGears)|Gets if at least one leading gear is enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLights](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLights)|Gets if lights are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledReactors](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledReactors)|Gets if grid is powered<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledThrusts](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledThrusts)|Gets if thrusts are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnableFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@EnableFirstPersonView)|Gets or set if player can use first person view<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Entity)|Gets information which entity is being controlled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Entity](Sandbox.Game.Entities.IMyControllableEntity@Entity)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyCameraController@Entity)|Gets Entity to which it is attached<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ForceFirstPersonCamera)|Gets or sets if camera should be first person<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyCameraController@ForceFirstPersonCamera)|Gets or sets if player can use only first person view<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[HeadLocalXAngle](Sandbox.Game.Entities.IMyControllableEntity@HeadLocalXAngle)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[HeadLocalYAngle](Sandbox.Game.Entities.IMyControllableEntity@HeadLocalYAngle)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[IsAutopilotControlled](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@IsAutopilotControlled)|Gets whether the entity is controller by autopilot<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[IsInFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@IsInFirstPersonView)|Gets or sets if the current camera view is first person.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[LastMotionIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastMotionIndicator)|Gets last motion indicator. User input W/A/S/D Space/C<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LastRotationIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastRotationIndicator)|Gets last rotation indicator. Z used for RollIndicator<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PrimaryLookaround](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PrimaryLookaround)|When false, blocks 3rd view look around<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningDistance](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningDistance)|Allows you to set a custom max distance which relative dampening to another entity will remain active.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningEntity](Sandbox.Game.Entities.IMyControllableEntity@RelativeDampeningEntity)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[RelativeDampeningTarget](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningTarget)|Allows you to get or set the relative dampening entity.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Toolbar](Sandbox.Game.Entities.IMyControllableEntity@Toolbar)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ToolbarType](Sandbox.Game.Entities.IMyControllableEntity@ToolbarType)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|

## Methods

|Member|Description|
|---|---|
|[CleanControls()](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@CleanControls)||
|[GetOverridingFocusMatrix()](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase@GetOverridingFocusMatrix)||
|[BeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@BeginShoot)|This will be called locally to start shooting with the given action<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CanSwitchAmmoMagazine()](Sandbox.Game.Entities.IMyControllableEntity@CanSwitchAmmoMagazine)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CanSwitchToWeapon(MyDefinitionId?)](Sandbox.Game.Entities.IMyControllableEntity@CanSwitchToWeapon)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CleanControls()](Sandbox.Game.Entities.IMyControllableEntity@CleanControls)|Implementation should clear previousControlled entities and cameras. They are no longer valid. Called on game load, if player is not online<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ControlCamera(MyCamera)](VRage.Game.ModAPI.Interfaces.IMyCameraController@ControlCamera)|Change camera properties now. Communication: from controller to camera.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Crouch()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Crouch)|Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Die()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Die)|Makes character dead.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Down()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Down)|Move direction : down. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DrawHud(IMyCameraController, long)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@DrawHud)|Updates hud logic, connected to entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EndShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@EndShoot)|This will be called locally to start shooting with the given action<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetCameraEntitySettings()](Sandbox.Game.Entities.IMyControllableEntity@GetCameraEntitySettings)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[GetHeadMatrix(bool, bool, bool, bool)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@GetHeadMatrix)|Gets head of character that controls this<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[GetOverridingFocusMatrix()](VRage.Game.ModAPI.Interfaces.IMyCameraController@GetOverridingFocusMatrix)|Transformation that should be used for target selection while focusing<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[HandlePickUp()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandlePickUp)|Does nothing.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[HandleUse()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandleUse)|Used to send "use" commands to camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Jump(Vector3)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Jump)|Character jump. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotate(Vector3, Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotate)|Defines user input. Call [MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped) on user input finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped)|Should be called when input is finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAssumeControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnAssumeControl)|Called when it is setted as new main camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@OnBeginShoot)|This will be called back from the sync object both on local and remote clients<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[OnEndShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@OnEndShoot)|This will be called back from the sync object both on local and remote clients<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[OnReleaseControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnReleaseControl)|Called when new camera controller setted, and this was main camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[PickUp()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUp)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUpContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUpContinues)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUpFinished()](Sandbox.Game.Entities.IMyControllableEntity@PickUpFinished)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[Rotate(Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyCameraController@Rotate)|Rotate camera controller.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[RotateStopped()](VRage.Game.ModAPI.Interfaces.IMyCameraController@RotateStopped)|Rotation of camera controller stopped.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[ShouldEndShootingOnPause(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@ShouldEndShootingOnPause)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ShowInventory()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowInventory)|Shows inventory gui of controlled Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ShowRemoteAccessMenu()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowRemoteAccessMenu)|Shows remote access menu<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ShowTerminal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowTerminal)|Shows terminal gui<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Sprint(bool)](Sandbox.Game.Entities.IMyControllableEntity@Sprint)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchAmmoMagazine()](Sandbox.Game.Entities.IMyControllableEntity@SwitchAmmoMagazine)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchBroadcasting()](Sandbox.Game.Entities.IMyControllableEntity@SwitchBroadcasting)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchDamping()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchDamping)|Switches damping state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchHandbrake()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHandbrake)|Switches handbrake state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchHelmet()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHelmet)|Switches helmet open/closed state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchLandingGears()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLandingGears)|Switches landing gears state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchLights()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLights)|Switches lights state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchReactors()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactors)|Switches reactors state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchReactorsLocal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactorsLocal)|Switches handbrake state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchThrusts()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchThrusts)|Turns on jetpack on character<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchToWeapon(MyDefinitionId)](Sandbox.Game.Entities.IMyControllableEntity@SwitchToWeapon)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchToWeapon(MyToolbarItemWeapon)](Sandbox.Game.Entities.IMyControllableEntity@SwitchToWeapon)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchWalk()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchWalk)|Switch between walk / run mode. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Up()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Up)|Move direction : up. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Use()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Use)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UseContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@UseContinues)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UseFinished()](Sandbox.Game.Entities.IMyControllableEntity@UseFinished)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)

**Implements:**  
* [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)  
* [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

