**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyControllableEntity: IMyControllableEntity
```

## Properties

|Member|Description|
|---|---|
|[AuxiliaryContext](Sandbox.Game.Entities.IMyControllableEntity@AuxiliaryContext)||
|[ControlContext](Sandbox.Game.Entities.IMyControllableEntity@ControlContext)||
|[ControllerInfo](Sandbox.Game.Entities.IMyControllableEntity@ControllerInfo)||
|[EnabledBroadcasting](Sandbox.Game.Entities.IMyControllableEntity@EnabledBroadcasting)||
|[Entity](Sandbox.Game.Entities.IMyControllableEntity@Entity)||
|[HeadLocalXAngle](Sandbox.Game.Entities.IMyControllableEntity@HeadLocalXAngle)||
|[HeadLocalYAngle](Sandbox.Game.Entities.IMyControllableEntity@HeadLocalYAngle)||
|[RelativeDampeningEntity](Sandbox.Game.Entities.IMyControllableEntity@RelativeDampeningEntity)||
|[Toolbar](Sandbox.Game.Entities.IMyControllableEntity@Toolbar)||
|[ToolbarType](Sandbox.Game.Entities.IMyControllableEntity@ToolbarType)||
|[CanSwitchLandingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@CanSwitchLandingGears)|Gets if entity can switch landing gears<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ControllerInfo](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ControllerInfo)|Gets information about who controls this Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledDamping](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledDamping)|Gets if Damping enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledHelmet](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledHelmet)|Gets if helmet is opened<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLeadingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLeadingGears)|Gets if at least one leading gear is enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLights](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLights)|Gets if lights are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledReactors](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledReactors)|Gets if grid is powered<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledThrusts](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledThrusts)|Gets if thrusts are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Entity)|Gets information which entity is being controlled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ForceFirstPersonCamera)|Gets or sets if camera should be first person<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[IsAutopilotControlled](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@IsAutopilotControlled)|Gets whether the entity is controller by autopilot<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LastMotionIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastMotionIndicator)|Gets last motion indicator. User input W/A/S/D Space/C<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LastRotationIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastRotationIndicator)|Gets last rotation indicator. Z used for RollIndicator<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PrimaryLookaround](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PrimaryLookaround)|When false, blocks 3rd view look around<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningDistance](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningDistance)|Allows you to set a custom max distance which relative dampening to another entity will remain active.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningTarget](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningTarget)|Allows you to get or set the relative dampening entity.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|

## Methods

|Member|Description|
|---|---|
|[BeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@BeginShoot)|This will be called locally to start shooting with the given action|
|[CanSwitchAmmoMagazine()](Sandbox.Game.Entities.IMyControllableEntity@CanSwitchAmmoMagazine)||
|[CanSwitchToWeapon(MyDefinitionId?)](Sandbox.Game.Entities.IMyControllableEntity@CanSwitchToWeapon)||
|[CleanControls()](Sandbox.Game.Entities.IMyControllableEntity@CleanControls)|Implementation should clear previousControlled entities and cameras. They are no longer valid. Called on game load, if player is not online|
|[EndShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@EndShoot)|This will be called locally to start shooting with the given action|
|[GetCameraEntitySettings()](Sandbox.Game.Entities.IMyControllableEntity@GetCameraEntitySettings)||
|[OnBeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@OnBeginShoot)|This will be called back from the sync object both on local and remote clients|
|[OnEndShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@OnEndShoot)|This will be called back from the sync object both on local and remote clients|
|[PickUpFinished()](Sandbox.Game.Entities.IMyControllableEntity@PickUpFinished)||
|[ShouldEndShootingOnPause(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@ShouldEndShootingOnPause)||
|[Sprint(bool)](Sandbox.Game.Entities.IMyControllableEntity@Sprint)||
|[SwitchAmmoMagazine()](Sandbox.Game.Entities.IMyControllableEntity@SwitchAmmoMagazine)||
|[SwitchBroadcasting()](Sandbox.Game.Entities.IMyControllableEntity@SwitchBroadcasting)||
|[SwitchToWeapon(MyDefinitionId)](Sandbox.Game.Entities.IMyControllableEntity@SwitchToWeapon)||
|[SwitchToWeapon(MyToolbarItemWeapon)](Sandbox.Game.Entities.IMyControllableEntity@SwitchToWeapon)||
|[UseFinished()](Sandbox.Game.Entities.IMyControllableEntity@UseFinished)||
|[Crouch()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Crouch)|Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Die()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Die)|Makes character dead.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Down()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Down)|Move direction : down. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DrawHud(IMyCameraController, long)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@DrawHud)|Updates hud logic, connected to entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[GetHeadMatrix(bool, bool, bool, bool)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@GetHeadMatrix)|Gets head of character that controls this<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Jump(Vector3)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Jump)|Character jump. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotate(Vector3, Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotate)|Defines user input. Call [MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped) on user input finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped)|Should be called when input is finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUp()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUp)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUpContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUpContinues)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
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
|[Up()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Up)|Move direction : up. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Use()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Use)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UseContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@UseContinues)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|

**Implements:**  
* [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)

**Inheritors:**  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyEntityRespawnComponentBase](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase)  
* [MyRemoteControl](Sandbox.Game.Entities.MyRemoteControl)  
* [MyShipController](Sandbox.Game.Entities.MyShipController)

