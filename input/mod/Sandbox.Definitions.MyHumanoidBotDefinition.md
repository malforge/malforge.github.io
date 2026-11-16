**Assembly:** Sandbox.Game.dll

```csharp
public class MyHumanoidBotDefinition: MyAgentDefinition
```

## Fields

|Member|Description|
|---|---|
|[static DEFAULT_AGENT_HEIGHT](Sandbox.Definitions.MyAgentDefinition@DEFAULT_AGENT_HEIGHT)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[static DEFAULT_AGENT_MAX_CLIMB](Sandbox.Definitions.MyAgentDefinition@DEFAULT_AGENT_MAX_CLIMB)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[static DEFAULT_AGENT_MAX_SLOPE](Sandbox.Definitions.MyAgentDefinition@DEFAULT_AGENT_MAX_SLOPE)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[static DEFAULT_AGENT_RADIUS](Sandbox.Definitions.MyAgentDefinition@DEFAULT_AGENT_RADIUS)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[static DEFAULT_PATH_ARRIVAL_RADIUS](Sandbox.Definitions.MyAgentDefinition@DEFAULT_PATH_ARRIVAL_RADIUS)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[static DEFAULT_PATHFINDING_RADIUS](Sandbox.Definitions.MyAgentDefinition@DEFAULT_PATHFINDING_RADIUS)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AdditionalAimErrorAngle](Sandbox.Definitions.MyHumanoidBotDefinition@AdditionalAimErrorAngle)|Extra aiming error applied on top of weapon spread, in radians (degrees in XML).|
|[AlertMergeDistance](Sandbox.Definitions.MyHumanoidBotDefinition@AlertMergeDistance)|Meters. An alert written this close to the one the squad already holds is the same event going on (a burst, a hull under fire) and only refreshes it; a farther one restarts the alert phases at the new point.|
|[AllowRouteFlight](Sandbox.Definitions.MyHumanoidBotDefinition@AllowRouteFlight)|False keeps the bot walking-only: navigation never arbitrates an unreachable goal into a jetpack flight route. Explicit flight orders (FlyTo behavior tree leaves) are unaffected.|
|[BlockInteractionAnimation](Sandbox.Definitions.MyHumanoidBotDefinition@BlockInteractionAnimation)||
|[CanTargetBlocks](Sandbox.Definitions.MyHumanoidBotDefinition@CanTargetBlocks)|The bot may hold a block or grid as its AI target, e.g. the seat of a boarded player.|
|[ChatMessageSet](Sandbox.Definitions.MyHumanoidBotDefinition@ChatMessageSet)|Subtype of the [MyNpcChatMessageSetDefinition](Sandbox.Definitions.MyNpcChatMessageSetDefinition) this bot speaks from; null means the bot never chats.|
|[CoverHoldMaxSeconds](Sandbox.Definitions.MyHumanoidBotDefinition@CoverHoldMaxSeconds)||
|[CoverHoldMinSeconds](Sandbox.Definitions.MyHumanoidBotDefinition@CoverHoldMinSeconds)|Seconds a bot holds cover from a threatening turret before a launcher carrier peeks out; rolled between min and max.|
|[FlightRetargetDistance](Sandbox.Definitions.MyHumanoidBotDefinition@FlightRetargetDistance)|Meters. A goal that moves less than this while the bot flies to it keeps the current flight leg.|
|[InventoryItems](Sandbox.Definitions.MyHumanoidBotDefinition@InventoryItems)||
|[LauncherSightRange](Sandbox.Definitions.MyHumanoidBotDefinition@LauncherSightRange)|Meters. Sight range of a bot carrying a rocket launcher; at least [RocketLauncherPreferredDistance](Sandbox.Definitions.MyHumanoidBotDefinition@RocketLauncherPreferredDistance) .|
|[MaxFlightSiteChecks](Sandbox.Definitions.MyHumanoidBotDefinition@MaxFlightSiteChecks)|Flight sites checked for walking reachability per decision.|
|[MaxRockets](Sandbox.Definitions.MyHumanoidBotDefinition@MaxRockets)|Rocket budget per bot; 0 = unlimited.|
|[PlayerGreetingAnimation](Sandbox.Definitions.MyHumanoidBotDefinition@PlayerGreetingAnimation)||
|[ReloadMagazineFraction](Sandbox.Definitions.MyHumanoidBotDefinition@ReloadMagazineFraction)|Fraction of the magazine capacity (0..1) at or below which a bot holding a rifle or pistol reloads instead of firing the last rounds; launchers reload only when empty.|
|[RocketBlastSafetyFactor](Sandbox.Definitions.MyHumanoidBotDefinition@RocketBlastSafetyFactor)|Minimum rocket launch distance is the missile explosion radius times this factor; at least 1.|
|[RocketLauncherPreferredDistance](Sandbox.Definitions.MyHumanoidBotDefinition@RocketLauncherPreferredDistance)|Meters. A character at least this far away makes a launcher-carrying bot draw the launcher.|
|[RocketLauncherReleaseDistance](Sandbox.Definitions.MyHumanoidBotDefinition@RocketLauncherReleaseDistance)|Meters. Below this a bot holding the launcher returns to its rifle or pistol; never above [RocketLauncherPreferredDistance](Sandbox.Definitions.MyHumanoidBotDefinition@RocketLauncherPreferredDistance) .|
|[RocketRegenerationSeconds](Sandbox.Definitions.MyHumanoidBotDefinition@RocketRegenerationSeconds)|Seconds until one spent rocket token comes back.|
|[RouteFlightFailureCooldown](Sandbox.Definitions.MyHumanoidBotDefinition@RouteFlightFailureCooldown)|Seconds after a failed jetpack flight during which navigation only walks.|
|[SmallArmsFireRange](Sandbox.Definitions.MyHumanoidBotDefinition@SmallArmsFireRange)|Meters. A bot holding a rifle or pistol (any gun but the launcher) fires only inside this distance and closes in until it is; never above [SmallArmsSightRange](Sandbox.Definitions.MyHumanoidBotDefinition@SmallArmsSightRange) .|
|[SmallArmsSightRange](Sandbox.Definitions.MyHumanoidBotDefinition@SmallArmsSightRange)|Meters. Sight range of a bot with no rocket launcher in its inventory: acquisition, tracking and shooting all stop here.|
|[StartingWeaponDefinitionId](Sandbox.Definitions.MyHumanoidBotDefinition@StartingWeaponDefinitionId)||
|[UseDoorFlightSites](Sandbox.Definitions.MyHumanoidBotDefinition@UseDoorFlightSites)|Doors the bot can open count as takeoff and landing sites.|
|[UseFlightSites](Sandbox.Definitions.MyHumanoidBotDefinition@UseFlightSites)|A bot on a large grid takes off only from air connected to open space, and lands where it can walk to its goal.|
|[AgentHeight](Sandbox.Definitions.MyAgentDefinition@AgentHeight)|This and AgentRadius/AgentMaxClimb are discretized at navmesh build: height & climb against MyPlatformGameSettings.NAVMESH_CELL_HEIGHT, radius against MyPlatformGameSettings.NAVMESH_CELL_SIZE. Height and radius round up to whole cells, climb rounds down and is raised to at least MyPlatformGameSettings.NAVMESH_MIN_AGENT_CLIMB.<br /><br />_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AgentMaxClimb](Sandbox.Definitions.MyAgentDefinition@AgentMaxClimb)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AgentMaxSlope](Sandbox.Definitions.MyAgentDefinition@AgentMaxSlope)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AgentRadius](Sandbox.Definitions.MyAgentDefinition@AgentRadius)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AttackLength](Sandbox.Definitions.MyAgentDefinition@AttackLength)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AttackRadius](Sandbox.Definitions.MyAgentDefinition@AttackRadius)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AttackSound](Sandbox.Definitions.MyAgentDefinition@AttackSound)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AvailableInSurvival](VRage.Game.MyDefinitionBase@AvailableInSurvival)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[BehaviorSubtype](Sandbox.Definitions.MyBotDefinition@BehaviorSubtype)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[BehaviorType](Sandbox.Definitions.MyBotDefinition@BehaviorType)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[BotBehaviorTree](Sandbox.Definitions.MyBotDefinition@BotBehaviorTree)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[BotModel](Sandbox.Definitions.MyAgentDefinition@BotModel)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[CanOpenDoors](Sandbox.Definitions.MyAgentDefinition@CanOpenDoors)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[CharacterDamage](Sandbox.Definitions.MyAgentDefinition@CharacterDamage)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[Commandable](Sandbox.Definitions.MyBotDefinition@Commandable)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[Context](VRage.Game.MyDefinitionBase@Context)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionArgs](VRage.Game.MyDefinitionBase@DescriptionArgs)|String used for shortcuts used in description<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionEnum](VRage.Game.MyDefinitionBase@DescriptionEnum)|Enum used for localization of description. Null for player created definitions.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionString](VRage.Game.MyDefinitionBase@DescriptionString)|String used for user created description which do not have localization support.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisableBroadcasting](Sandbox.Definitions.MyAgentDefinition@DisableBroadcasting)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[DoorOpenDistance](Sandbox.Definitions.MyAgentDefinition@DoorOpenDistance)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[Enabled](VRage.Game.MyDefinitionBase@Enabled)|Definition can be disabled by mod, then it will be removed from definition manager<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[FactionTag](Sandbox.Definitions.MyAgentDefinition@FactionTag)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[GridDamage](Sandbox.Definitions.MyAgentDefinition@GridDamage)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[Icons](VRage.Game.MyDefinitionBase@Icons)|Icons for the definition, they are used from top to bottom.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Id](VRage.Game.MyDefinitionBase@Id)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[IgnoredByAITargeting](Sandbox.Definitions.MyAgentDefinition@IgnoredByAITargeting)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[InventoryContainerTypeId](Sandbox.Definitions.MyAgentDefinition@InventoryContainerTypeId)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[InventoryContentGenerated](Sandbox.Definitions.MyAgentDefinition@InventoryContentGenerated)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[Invulnerable](Sandbox.Definitions.MyAgentDefinition@Invulnerable)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[JoinSpawnerFaction](Sandbox.Definitions.MyAgentDefinition@JoinSpawnerFaction)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[PathArrivalRadius](Sandbox.Definitions.MyAgentDefinition@PathArrivalRadius)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[PathfindingRadius](Sandbox.Definitions.MyAgentDefinition@PathfindingRadius)|Clearance radius (meters) used when querying the grid octree pathfinding for flight routes.<br /><br />_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[Public](VRage.Game.MyDefinitionBase@Public)|Indicates if definition should be offered in Cube builder<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[RemoveAfterDeath](Sandbox.Definitions.MyAgentDefinition@RemoveAfterDeath)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[RemoveTimeMs](Sandbox.Definitions.MyAgentDefinition@RemoveTimeMs)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[RespawnTimeMs](Sandbox.Definitions.MyAgentDefinition@RespawnTimeMs)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[SteeringBehaviors](Sandbox.Definitions.MyAgentDefinition@SteeringBehaviors)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[TargetCharacters](Sandbox.Definitions.MyAgentDefinition@TargetCharacters)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[TargetGrids](Sandbox.Definitions.MyAgentDefinition@TargetGrids)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[TargetType](Sandbox.Definitions.MyAgentDefinition@TargetType)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[TypeDefinitionId](Sandbox.Definitions.MyBotDefinition@TypeDefinitionId)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[UseFactionColor](Sandbox.Definitions.MyAgentDefinition@UseFactionColor)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[WildlifeCategory](Sandbox.Definitions.MyAgentDefinition@WildlifeCategory)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|

## Properties

|Member|Description|
|---|---|
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameEnum](VRage.Game.MyDefinitionBase@DisplayNameEnum)|Enum used for localization of display name. Null for player created definitions.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameString](VRage.Game.MyDefinitionBase@DisplayNameString)|String name used for user created definitions which do not have localization support.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyHumanoidBotDefinition()](Sandbox.Definitions.MyHumanoidBotDefinition@.ctor)||
|[MyAgentDefinition()](Sandbox.Definitions.MyAgentDefinition@.ctor)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[MyBotDefinition()](Sandbox.Definitions.MyBotDefinition@.ctor)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[AddItems(MyCharacter)](Sandbox.Definitions.MyHumanoidBotDefinition@AddItems)||
|[AddItems(MyCharacter)](Sandbox.Definitions.MyAgentDefinition@AddItems)|_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[AddItems(MyCharacter)](Sandbox.Definitions.MyBotDefinition@AddItems)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetBotModel(float)](Sandbox.Definitions.MyAgentDefinition@GetBotModel)|Picks a character model from BotModels by weight, or returns BotModel when none are valid.<br /><br />_Inherited from [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase) ˃ [MyBotDefinition](Sandbox.Definitions.MyBotDefinition) ˃ [MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition)

