**Assembly:** VRage.Game.dll

```csharp
public interface IMyControllableEntity
```

Describes that player can take under control (mods interface)

## Properties

|Member|Description|
|---|---|
|[CanSwitchLandingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@CanSwitchLandingGears)|Gets if entity can switch landing gears|
|[ControllerInfo](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ControllerInfo)|Gets information about who controls this Entity|
|[EnabledDamping](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledDamping)|Gets if Damping enabled|
|[EnabledHelmet](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledHelmet)|Gets if helmet is opened|
|[EnabledLeadingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLeadingGears)|Gets if at least one leading gear is enabled|
|[EnabledLights](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLights)|Gets if lights are enabled|
|[EnabledReactors](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledReactors)|Gets if grid is powered|
|[EnabledThrusts](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledThrusts)|Gets if thrusts are enabled|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Entity)|Gets information which entity is being controlled|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ForceFirstPersonCamera)|Gets or sets if camera should be first person|
|[IsAutopilotControlled](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@IsAutopilotControlled)|Gets whether the entity is controller by autopilot|
|[LastMotionIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastMotionIndicator)|Gets last motion indicator. User input W/A/S/D Space/C|
|[LastRotationIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastRotationIndicator)|Gets last rotation indicator. Z used for RollIndicator|
|[PrimaryLookaround](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PrimaryLookaround)|When false, blocks 3rd view look around|
|[RelativeDampeningDistance](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningDistance)|Allows you to set a custom max distance which relative dampening to another entity will remain active.|
|[RelativeDampeningTarget](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningTarget)|Allows you to get or set the relative dampening entity.|

## Methods

|Member|Description|
|---|---|
|[Crouch()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Crouch)|Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.|
|[Die()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Die)|Makes character dead.|
|[Down()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Down)|Move direction : down. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.|
|[DrawHud(IMyCameraController, long)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@DrawHud)|Updates hud logic, connected to entity|
|[GetHeadMatrix(bool, bool, bool, bool)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@GetHeadMatrix)|Gets head of character that controls this|
|[Jump(Vector3)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Jump)|Character jump. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.|
|[MoveAndRotate(Vector3, Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotate)|Defines user input. Call [MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped) on user input finished|
|[MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped)|Should be called when input is finished|
|[PickUp()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUp)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp) |
|[PickUpContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUpContinues)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp) |
|[ShowInventory()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowInventory)|Shows inventory gui of controlled Entity|
|[ShowRemoteAccessMenu()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowRemoteAccessMenu)|Shows remote access menu|
|[ShowTerminal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowTerminal)|Shows terminal gui|
|[SwitchDamping()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchDamping)|Switches damping state|
|[SwitchHandbrake()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHandbrake)|Switches handbrake state|
|[SwitchHelmet()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHelmet)|Switches helmet open/closed state|
|[SwitchLandingGears()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLandingGears)|Switches landing gears state|
|[SwitchLights()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLights)|Switches lights state|
|[SwitchReactors()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactors)|Switches reactors state|
|[SwitchReactorsLocal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactorsLocal)|Switches handbrake state|
|[SwitchThrusts()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchThrusts)|Turns on jetpack on character|
|[SwitchWalk()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchWalk)|Switch between walk / run mode. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.|
|[Up()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Up)|Move direction : up. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.|
|[Use()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Use)||
|[UseContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@UseContinues)||

**Inheritors:**  
* [IMyCharacter](VRage.Game.ModAPI.IMyCharacter)  
* [IMyCockpit](Sandbox.ModAPI.IMyCockpit)  
* [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)  
* [IMyCryoChamber](Sandbox.ModAPI.IMyCryoChamber)  
* [IMyRemoteControl](Sandbox.ModAPI.IMyRemoteControl)  
* [IMyShipController](Sandbox.ModAPI.IMyShipController)  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyEntityRespawnComponentBase](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase)  
* [MyRemoteControl](Sandbox.Game.Entities.MyRemoteControl)  
* [MyShipController](Sandbox.Game.Entities.MyShipController)

