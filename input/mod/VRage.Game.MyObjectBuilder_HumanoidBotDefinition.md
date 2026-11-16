**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_HumanoidBotDefinition: MyObjectBuilder_AgentDefinition
```

## Fields

|Member|Description|
|---|---|
|[AdditionalAimErrorAngle](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@AdditionalAimErrorAngle)||
|[AlertMergeDistance](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@AlertMergeDistance)|Meters. An alert (hull hit, gunshot) this close to the one the squad already holds only refreshes it; a farther one moves the alert and restarts the squad's alert phases there.|
|[AllowRouteFlight](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@AllowRouteFlight)||
|[BlockInteractionAnimation](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@BlockInteractionAnimation)||
|[CanTargetBlocks](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@CanTargetBlocks)|Lets the bot hold a block or grid as its AI target (a boarded player's seat); TargetGrids stays about biting grids.|
|[ChatMessageSet](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@ChatMessageSet)||
|[CoverHoldMaxSeconds](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@CoverHoldMaxSeconds)||
|[CoverHoldMinSeconds](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@CoverHoldMinSeconds)|Seconds a bot holds its cover from a threatening turret before a launcher carrier peeks out; the hold is rolled between min and max.|
|[FlightRetargetDistance](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@FlightRetargetDistance)|Meters. A goal that moves less than this while the bot flies to it keeps the current flight leg.|
|[InventoryItems](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@InventoryItems)||
|[LauncherSightRange](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@LauncherSightRange)|Meters. Sight range of a bot carrying a rocket launcher; keep it above RocketLauncherPreferredDistance or the launcher never comes out.|
|[MaxFlightSiteChecks](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@MaxFlightSiteChecks)|Flight sites checked for walking reachability per decision, cheapest detour first; each check is a navmesh query.|
|[MaxRockets](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@MaxRockets)|Rocket budget per bot; 0 = unlimited. One token per launch, one back every RocketRegenerationSeconds.|
|[PlayerGreetingAnimation](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@PlayerGreetingAnimation)||
|[ReloadMagazineFraction](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@ReloadMagazineFraction)|Fraction of the magazine capacity (0..1) at or below which a bot holding a rifle or pistol reloads instead of shooting the last rounds; 0 reloads only when empty. Launchers reload only when empty.|
|[RocketBlastSafetyFactor](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@RocketBlastSafetyFactor)|Minimum rocket launch distance is the missile explosion radius times this factor.|
|[RocketLauncherPreferredDistance](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@RocketLauncherPreferredDistance)|Meters. A character at least this far away makes a launcher-carrying bot draw the launcher.|
|[RocketLauncherReleaseDistance](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@RocketLauncherReleaseDistance)|Meters. A bot holding the launcher goes back to its rifle or pistol once the character is closer than this.|
|[RocketRegenerationSeconds](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@RocketRegenerationSeconds)||
|[RouteFlightFailureCooldown](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@RouteFlightFailureCooldown)|Seconds after a failed jetpack flight (stalled, landed short, nothing to land on) during which navigation only walks.|
|[SmallArmsFireRange](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@SmallArmsFireRange)|Meters. A bot holding a rifle or pistol (any gun but the launcher) opens fire only inside this distance and closes in from sight range until it is; never above SmallArmsSightRange.|
|[SmallArmsSightRange](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@SmallArmsSightRange)|Meters. How far a bot without a rocket launcher spots, tracks and shoots targets; combat tree scans and the engage check all use it.|
|[StartingItem](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@StartingItem)||
|[UseDoorFlightSites](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@UseDoorFlightSites)|Doors the bot can open count as takeoff and landing sites: it opens the door and flies out through it.|
|[UseFlightSites](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@UseFlightSites)|A bot on a large grid takes off only from air connected to open space, and lands where it can walk to its goal.|
|[AgentHeight](VRage.Game.MyObjectBuilder_AgentDefinition@AgentHeight)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AgentMaxClimb](VRage.Game.MyObjectBuilder_AgentDefinition@AgentMaxClimb)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AgentMaxSlope](VRage.Game.MyObjectBuilder_AgentDefinition@AgentMaxSlope)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AgentRadius](VRage.Game.MyObjectBuilder_AgentDefinition@AgentRadius)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AttackLength](VRage.Game.MyObjectBuilder_AgentDefinition@AttackLength)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AttackRadius](VRage.Game.MyObjectBuilder_AgentDefinition@AttackRadius)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AttackSound](VRage.Game.MyObjectBuilder_AgentDefinition@AttackSound)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[AvailableInSurvival](VRage.Game.MyObjectBuilder_DefinitionBase@AvailableInSurvival)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[BehaviorSubtype](VRage.Game.MyObjectBuilder_BotDefinition@BehaviorSubtype)|_Inherited from [MyObjectBuilder_BotDefinition](VRage.Game.MyObjectBuilder_BotDefinition)_|
|[BehaviorType](VRage.Game.MyObjectBuilder_BotDefinition@BehaviorType)|_Inherited from [MyObjectBuilder_BotDefinition](VRage.Game.MyObjectBuilder_BotDefinition)_|
|[BotBehaviorTree](VRage.Game.MyObjectBuilder_BotDefinition@BotBehaviorTree)|_Inherited from [MyObjectBuilder_BotDefinition](VRage.Game.MyObjectBuilder_BotDefinition)_|
|[BotModel](VRage.Game.MyObjectBuilder_AgentDefinition@BotModel)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[BotModels](VRage.Game.MyObjectBuilder_AgentDefinition@BotModels)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[CanOpenDoors](VRage.Game.MyObjectBuilder_AgentDefinition@CanOpenDoors)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[CharacterDamage](VRage.Game.MyObjectBuilder_AgentDefinition@CharacterDamage)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[Commandable](VRage.Game.MyObjectBuilder_BotDefinition@Commandable)|_Inherited from [MyObjectBuilder_BotDefinition](VRage.Game.MyObjectBuilder_BotDefinition)_|
|[Description](VRage.Game.MyObjectBuilder_DefinitionBase@Description)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DescriptionArgs](VRage.Game.MyObjectBuilder_DefinitionBase@DescriptionArgs)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DisableBroadcasting](VRage.Game.MyObjectBuilder_AgentDefinition@DisableBroadcasting)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[DisplayName](VRage.Game.MyObjectBuilder_DefinitionBase@DisplayName)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DLCs](VRage.Game.MyObjectBuilder_DefinitionBase@DLCs)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DoorOpenDistance](VRage.Game.MyObjectBuilder_AgentDefinition@DoorOpenDistance)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[Enabled](VRage.Game.MyObjectBuilder_DefinitionBase@Enabled)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[FactionTag](VRage.Game.MyObjectBuilder_AgentDefinition@FactionTag)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[GridDamage](VRage.Game.MyObjectBuilder_AgentDefinition@GridDamage)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[Icons](VRage.Game.MyObjectBuilder_DefinitionBase@Icons)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Id](VRage.Game.MyObjectBuilder_DefinitionBase@Id)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[IgnoredByAITargeting](VRage.Game.MyObjectBuilder_AgentDefinition@IgnoredByAITargeting)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[InventoryContainerTypeId](VRage.Game.MyObjectBuilder_AgentDefinition@InventoryContainerTypeId)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[InventoryContentGenerated](VRage.Game.MyObjectBuilder_AgentDefinition@InventoryContentGenerated)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[Invulnerable](VRage.Game.MyObjectBuilder_AgentDefinition@Invulnerable)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[JoinSpawnerFaction](VRage.Game.MyObjectBuilder_AgentDefinition@JoinSpawnerFaction)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[PathArrivalRadius](VRage.Game.MyObjectBuilder_AgentDefinition@PathArrivalRadius)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[PathfindingRadius](VRage.Game.MyObjectBuilder_AgentDefinition@PathfindingRadius)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[Public](VRage.Game.MyObjectBuilder_DefinitionBase@Public)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[RemoveAfterDeath](VRage.Game.MyObjectBuilder_AgentDefinition@RemoveAfterDeath)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[RemoveTimeMs](VRage.Game.MyObjectBuilder_AgentDefinition@RemoveTimeMs)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[RespawnTimeMs](VRage.Game.MyObjectBuilder_AgentDefinition@RespawnTimeMs)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[SteeringBehaviors](VRage.Game.MyObjectBuilder_AgentDefinition@SteeringBehaviors)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[TargetCharacters](VRage.Game.MyObjectBuilder_AgentDefinition@TargetCharacters)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[TargetGrids](VRage.Game.MyObjectBuilder_AgentDefinition@TargetGrids)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[TargetType](VRage.Game.MyObjectBuilder_AgentDefinition@TargetType)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[UseFactionColor](VRage.Game.MyObjectBuilder_AgentDefinition@UseFactionColor)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[WildlifeCategory](VRage.Game.MyObjectBuilder_AgentDefinition@WildlifeCategory)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_HumanoidBotDefinition()](VRage.Game.MyObjectBuilder_HumanoidBotDefinition@.ctor)||
|[MyObjectBuilder_AgentDefinition()](VRage.Game.MyObjectBuilder_AgentDefinition@.ctor)|_Inherited from [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)_|
|[MyObjectBuilder_BotDefinition()](VRage.Game.MyObjectBuilder_BotDefinition@.ctor)|_Inherited from [MyObjectBuilder_BotDefinition](VRage.Game.MyObjectBuilder_BotDefinition)_|

## Methods

|Member|Description|
|---|---|
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase) ˃ [MyObjectBuilder_BotDefinition](VRage.Game.MyObjectBuilder_BotDefinition) ˃ [MyObjectBuilder_AgentDefinition](VRage.Game.MyObjectBuilder_AgentDefinition)

