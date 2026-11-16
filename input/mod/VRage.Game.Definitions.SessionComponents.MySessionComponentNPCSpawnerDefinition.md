**Assembly:** VRage.Game.dll

```csharp
public class MySessionComponentNPCSpawnerDefinition: MySessionComponentDefinition
```

## Properties

|Member|Description|
|---|---|
|[CockpitReservationTimeMs](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@CockpitReservationTimeMs)||
|[CoverCandidates](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@CoverCandidates)|Positions a bot samples around itself when looking for cover from a turret.|
|[CoverSampleRadius](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@CoverSampleRadius)|Meters around the bot in which cover candidates are drawn.|
|[CoverTurretsConsidered](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@CoverTurretsConsidered)|How many of the nearest threatening turrets a cover candidate must hide from.|
|[EncounterDespawnDistance](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@EncounterDespawnDistance)||
|[PeekSideStep](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@PeekSideStep)|Meters a launcher bot steps sideways out of cover to fire at a turret; at least 0.5.|
|[PeeksWithoutFiringLineBeforeNewCover](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@PeeksWithoutFiringLineBeforeNewCover)|Peeks that find no firing line to a turret, counted until a rocket is fired from the cover, before a launcher bot gives it up; at least 1.|
|[ProvocationMemoryMs](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@ProvocationMemoryMs)|How long a hit on a squad member keeps the attacker hostile to a neutral squad.|
|[RocketLaunchClearance](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@RocketLaunchClearance)|Radius in meters a rocket's path must have free of obstacles for a launcher bot to fire along it.|
|[StationChatMessageSet](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@StationChatMessageSet)|Chat message set forced on faction-station NPCs; null lets each bot definition's own set apply.|
|[StationDespawnDistance](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@StationDespawnDistance)||
|[ThreatScanRadius](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@ThreatScanRadius)|Meters around a squad's anchor in which grids are examined for threatening turrets and hostile pilots.|
|[UpdateInterval](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@UpdateInterval)||

## Constructors

|Member|Description|
|---|---|
|[MySessionComponentNPCSpawnerDefinition()](VRage.Game.Definitions.SessionComponents.MySessionComponentNPCSpawnerDefinition@.ctor)||

**Inheritance:**   MySessionComponentDefinition <sub>prohibited</sub>

