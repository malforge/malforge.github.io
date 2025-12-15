**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyGlobalEncounterComponent
```

Describes entity component used for global encounters grids

## Properties

|Member|Description|
|---|---|
|[EncounterId](Sandbox.ModAPI.IMyGlobalEncounterComponent@EncounterId)|Gets encounter id, generated id when encounter is created|
|[GpsCreated](Sandbox.ModAPI.IMyGlobalEncounterComponent@GpsCreated)|Gets true if GPS was created with this component when registered|
|[RegisteredAsEncounter](Sandbox.ModAPI.IMyGlobalEncounterComponent@RegisteredAsEncounter)|Gets true if component was registered to GE system|
|[SpawnGroupName](Sandbox.ModAPI.IMyGlobalEncounterComponent@SpawnGroupName)|Gets spawn group name, which was used when spawning GE|

## Methods

|Member|Description|
|---|---|
|[AddGlobalEncounterComponent(IMyCubeGrid)](Sandbox.ModAPI.IMyGlobalEncounterComponent@AddGlobalEncounterComponent)|Adds new instance of Global Encounter Component to the grid with the same encounter id|
|[UnregisterFromEncounter()](Sandbox.ModAPI.IMyGlobalEncounterComponent@UnregisterFromEncounter)|Unregisters entity from the encounter so it is not longer considered as part of the global encounter.|

