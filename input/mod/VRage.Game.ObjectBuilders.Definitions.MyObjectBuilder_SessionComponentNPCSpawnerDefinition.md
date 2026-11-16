**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_SessionComponentNPCSpawnerDefinition: MyObjectBuilder_SessionComponentDefinition
```

## Fields

|Member|Description|
|---|---|
|[CockpitReservationTimeMs](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@CockpitReservationTimeMs)||
|[CoverCandidates](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@CoverCandidates)|Positions a bot samples around itself when looking for cover from a turret or for a guard spot during an alert; a few are tested per behavior tree tick.|
|[CoverSampleRadius](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@CoverSampleRadius)|Meters around the bot in which cover candidates are drawn.|
|[CoverTurretsConsidered](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@CoverTurretsConsidered)|How many of the nearest threatening turrets a cover candidate must hide from.|
|[EncounterDespawnDistance](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@EncounterDespawnDistance)||
|[PeekSideStep](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@PeekSideStep)|Meters per side step a launcher bot takes out of cover to fire at a turret; after a shot from a sampler firing spot beyond the widest side step the bot takes new cover nearby instead of walking back.|
|[PeeksWithoutFiringLineBeforeNewCover](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@PeeksWithoutFiringLineBeforeNewCover)|Peeks that find no firing line to a turret, counted until a rocket is fired from the cover, before a launcher bot gives it up and looks for another.|
|[ProvocationMemoryMs](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@ProvocationMemoryMs)|How long a hit on a squad member keeps the attacker hostile to a neutral squad.|
|[RocketLaunchClearance](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@RocketLaunchClearance)|Radius in meters a rocket's path must have free of obstacles for a launcher bot to fire along it: the round's body plus the launcher's spread.|
|[StationChatMessageSet](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@StationChatMessageSet)||
|[StationDespawnDistance](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@StationDespawnDistance)||
|[ThreatScanRadius](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@ThreatScanRadius)|Meters around a squad's anchor in which grids are examined for threatening turrets and hostile pilots.|
|[UpdateInterval](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@UpdateInterval)||
|[AvailableInSurvival](VRage.Game.MyObjectBuilder_DefinitionBase@AvailableInSurvival)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Description](VRage.Game.MyObjectBuilder_DefinitionBase@Description)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DescriptionArgs](VRage.Game.MyObjectBuilder_DefinitionBase@DescriptionArgs)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DisplayName](VRage.Game.MyObjectBuilder_DefinitionBase@DisplayName)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DLCs](VRage.Game.MyObjectBuilder_DefinitionBase@DLCs)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Enabled](VRage.Game.MyObjectBuilder_DefinitionBase@Enabled)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Icons](VRage.Game.MyObjectBuilder_DefinitionBase@Icons)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Id](VRage.Game.MyObjectBuilder_DefinitionBase@Id)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Public](VRage.Game.MyObjectBuilder_DefinitionBase@Public)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_SessionComponentNPCSpawnerDefinition()](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentNPCSpawnerDefinition@.ctor)||
|[MyObjectBuilder_SessionComponentDefinition()](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentDefinition@.ctor)|_Inherited from [MyObjectBuilder_SessionComponentDefinition](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentDefinition)_|

## Methods

|Member|Description|
|---|---|
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase) ˃ [MyObjectBuilder_SessionComponentDefinition](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_SessionComponentDefinition)

