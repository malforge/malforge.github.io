**Assembly:** Sandbox.Game.dll

```csharp
public class MySpawnGroupDefinition: MyDefinitionBase
```

## Fields

|Member|Description|
|---|---|
|[EnableNpcResources](Sandbox.Definitions.MySpawnGroupDefinition@EnableNpcResources)||
|[EnableTradingStationVisit](Sandbox.Definitions.MySpawnGroupDefinition@EnableTradingStationVisit)||
|[FactionSubEncounters](Sandbox.Definitions.MySpawnGroupDefinition@FactionSubEncounters)||
|[Frequency](Sandbox.Definitions.MySpawnGroupDefinition@Frequency)||
|[GlobalEncounterSettings](Sandbox.Definitions.MySpawnGroupDefinition@GlobalEncounterSettings)||
|[HostileSubEncounters](Sandbox.Definitions.MySpawnGroupDefinition@HostileSubEncounters)||
|[IsCargoShip](Sandbox.Definitions.MySpawnGroupDefinition@IsCargoShip)||
|[IsEncounter](Sandbox.Definitions.MySpawnGroupDefinition@IsEncounter)||
|[PlanetaryInstallationSettings](Sandbox.Definitions.MySpawnGroupDefinition@PlanetaryInstallationSettings)||
|[Prefabs](Sandbox.Definitions.MySpawnGroupDefinition@Prefabs)||
|[RandomizedPaint](Sandbox.Definitions.MySpawnGroupDefinition@RandomizedPaint)||
|[ReactorsOn](Sandbox.Definitions.MySpawnGroupDefinition@ReactorsOn)||
|[Voxels](Sandbox.Definitions.MySpawnGroupDefinition@Voxels)||
|[AvailableInSurvival](VRage.Game.MyDefinitionBase@AvailableInSurvival)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Context](VRage.Game.MyDefinitionBase@Context)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionArgs](VRage.Game.MyDefinitionBase@DescriptionArgs)|String used for shortcuts used in description<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionEnum](VRage.Game.MyDefinitionBase@DescriptionEnum)|Enum used for localization of description. Null for player created definitions.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionString](VRage.Game.MyDefinitionBase@DescriptionString)|String used for user created description which do not have localization support.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameEnum](VRage.Game.MyDefinitionBase@DisplayNameEnum)|Enum used for localization of display name. Null for player created definitions.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameString](VRage.Game.MyDefinitionBase@DisplayNameString)|String name used for user created definitions which do not have localization support.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Enabled](VRage.Game.MyDefinitionBase@Enabled)|Definition can be disabled by mod, then it will be removed from definition manager<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Icons](VRage.Game.MyDefinitionBase@Icons)|Icons for the definition, they are used from top to bottom.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Id](VRage.Game.MyDefinitionBase@Id)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Public](VRage.Game.MyDefinitionBase@Public)|Indicates if definition should be offered in Cube builder<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Properties

|Member|Description|
|---|---|
|[FactionSubtypeIds](Sandbox.Definitions.MySpawnGroupDefinition@FactionSubtypeIds)||
|[FactionTypesSubtypeIds](Sandbox.Definitions.MySpawnGroupDefinition@FactionTypesSubtypeIds)||
|[IsGlobalEncounter](Sandbox.Definitions.MySpawnGroupDefinition@IsGlobalEncounter)||
|[IsPirate](Sandbox.Definitions.MySpawnGroupDefinition@IsPirate)||
|[IsPlanetaryEncounter](Sandbox.Definitions.MySpawnGroupDefinition@IsPlanetaryEncounter)||
|[IsValid](Sandbox.Definitions.MySpawnGroupDefinition@IsValid)||
|[MaxFactionSubEncounters](Sandbox.Definitions.MySpawnGroupDefinition@MaxFactionSubEncounters)|Max count of faction sub encounters to spawn|
|[MaxHostileSubEncounters](Sandbox.Definitions.MySpawnGroupDefinition@MaxHostileSubEncounters)|Max count of hostile sub encounters to spawn|
|[MinFactionSubEncounters](Sandbox.Definitions.MySpawnGroupDefinition@MinFactionSubEncounters)|Min count of faction sub encounters to spawn|
|[MinHostileSubEncounters](Sandbox.Definitions.MySpawnGroupDefinition@MinHostileSubEncounters)|Min count of hostile sub encounters to spawn|
|[SpawnRadius](Sandbox.Definitions.MySpawnGroupDefinition@SpawnRadius)||
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MySpawnGroupDefinition()](Sandbox.Definitions.MySpawnGroupDefinition@.ctor)||
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[GetObjectBuilder()](Sandbox.Definitions.MySpawnGroupDefinition@GetObjectBuilder)||
|[ReloadPrefabs()](Sandbox.Definitions.MySpawnGroupDefinition@ReloadPrefabs)||
|[TryGetOwnerId(out long, bool)](Sandbox.Definitions.MySpawnGroupDefinition@TryGetOwnerId)|Tries to get owner id for spawning this group based on [FactionSubtypeIds](Sandbox.Definitions.MySpawnGroupDefinition@FactionSubtypeIds) and [FactionTypesSubtypeIds](Sandbox.Definitions.MySpawnGroupDefinition@FactionTypesSubtypeIds) |
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase)

