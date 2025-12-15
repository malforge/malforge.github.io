**Assembly:** VRage.Game.dll

```csharp
public class MyDefinitionBase
```

## Fields

|Member|Description|
|---|---|
|[AvailableInSurvival](VRage.Game.MyDefinitionBase@AvailableInSurvival)||
|[Context](VRage.Game.MyDefinitionBase@Context)||
|[DescriptionArgs](VRage.Game.MyDefinitionBase@DescriptionArgs)|String used for shortcuts used in description|
|[DescriptionEnum](VRage.Game.MyDefinitionBase@DescriptionEnum)|Enum used for localization of description. Null for player created definitions.|
|[DescriptionString](VRage.Game.MyDefinitionBase@DescriptionString)|String used for user created description which do not have localization support.|
|[DisplayNameEnum](VRage.Game.MyDefinitionBase@DisplayNameEnum)|Enum used for localization of display name. Null for player created definitions.|
|[DisplayNameString](VRage.Game.MyDefinitionBase@DisplayNameString)|String name used for user created definitions which do not have localization support.|
|[Enabled](VRage.Game.MyDefinitionBase@Enabled)|Definition can be disabled by mod, then it will be removed from definition manager|
|[Icons](VRage.Game.MyDefinitionBase@Icons)|Icons for the definition, they are used from top to bottom.|
|[Id](VRage.Game.MyDefinitionBase@Id)||
|[Public](VRage.Game.MyDefinitionBase@Public)|Indicates if definition should be offered in Cube builder|

## Properties

|Member|Description|
|---|---|
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)||

## Constructors

|Member|Description|
|---|---|
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)||
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)||
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)||

**Inheritors:**  
* [MyAiCommandDefinition](Sandbox.Definitions.MyAiCommandDefinition)  
* [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)  
* [MyAssetModifierDefinition](Sandbox.Definitions.MyAssetModifierDefinition)  
* [MyAsteroidGeneratorDefinition](Sandbox.Definitions.MyAsteroidGeneratorDefinition)  
* [MyAudioDefinition](VRage.Game.MyAudioDefinition)  
* [MyAudioEffectDefinition](Sandbox.Definitions.MyAudioEffectDefinition)  
* [MyBehaviorDefinition](Sandbox.Definitions.MyBehaviorDefinition)  
* [MyBlockVariantGroup](Sandbox.Definitions.MyBlockVariantGroup)  
* [MyBlueprintClassDefinition](Sandbox.Definitions.MyBlueprintClassDefinition)  
* [MyBlueprintDefinitionBase](Sandbox.Definitions.MyBlueprintDefinitionBase)  
* [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)  
* [MyCharacterDefinition](Sandbox.Definitions.MyCharacterDefinition)  
* [MyComponentDefinitionBase](VRage.Game.MyComponentDefinitionBase)  
* [MyComponentGroupDefinition](Sandbox.Definitions.MyComponentGroupDefinition)  
* [MyContainerDefinition](VRage.Game.MyContainerDefinition)  
* [MyContainerTypeDefinition](Sandbox.Definitions.MyContainerTypeDefinition)  
* [MyContractTypeDefinition](Sandbox.Definitions.MyContractTypeDefinition)  
* [MyControllerSchemaDefinition](Sandbox.Definitions.MyControllerSchemaDefinition)  
* [MyControllerSchemeDefinition](Sandbox.Definitions.MyControllerSchemeDefinition)  
* [MyCubeBlockTagDefinition](Sandbox.Definitions.MyCubeBlockTagDefinition)  
* [MyCurveDefinition](VRage.Game.MyCurveDefinition)  
* [MyDebrisDefinition](Sandbox.Definitions.MyDebrisDefinition)  
* [MyDebugScreenSearchCacheDefinition](Sandbox.Definitions.MyDebugScreenSearchCacheDefinition)  
* [MyDlcDefinition](VRage.Game.Definitions.MyDlcDefinition)  
* [MyDropContainerDefinition](Sandbox.Definitions.MyDropContainerDefinition)  
* [MyEdgesDefinition](Sandbox.Definitions.MyEdgesDefinition)  
* [MyEmoteDefinition](Sandbox.Definitions.MyEmoteDefinition)  
* [MyEntityStatDefinition](Sandbox.Definitions.MyEntityStatDefinition)  
* [MyEnvironmentDefinition](Sandbox.Definitions.MyEnvironmentDefinition)  
* [MyEnvironmentItemsDefinition](Sandbox.Definitions.MyEnvironmentItemsDefinition)  
* [MyExhaustEffectDefinition](Sandbox.Definitions.MyExhaustEffectDefinition)  
* [MyFactionDefinition](Sandbox.Definitions.MyFactionDefinition)  
* [MyFactionNameDefinition](Sandbox.Definitions.MyFactionNameDefinition)  
* [MyFactionTypeDefinition](Sandbox.Definitions.MyFactionTypeDefinition)  
* [MyFlareDefinition](Sandbox.Definitions.MyFlareDefinition)  
* [MyFontDefinition](VRage.Game.Definitions.MyFontDefinition)  
* [MyGameDefinition](VRage.Game.Definitions.MyGameDefinition)  
* [MyGasProperties](Sandbox.Definitions.MyGasProperties)  
* [MyGhostCharacterDefinition](Sandbox.Definitions.MyGhostCharacterDefinition)  
* [MyGlobalEventDefinition](Sandbox.Definitions.MyGlobalEventDefinition)  
* [MyGpsCollectionDefinition](Sandbox.Definitions.MyGpsCollectionDefinition)  
* [MyGridCreateToolDefinition](Sandbox.Definitions.MyGridCreateToolDefinition)  
* [MyGuiBlockCategoryDefinition](Sandbox.Definitions.MyGuiBlockCategoryDefinition)  
* [MyGuiTextureAtlasDefinition](VRage.Game.Definitions.MyGuiTextureAtlasDefinition)  
* [MyHandItemDefinition](Sandbox.Definitions.MyHandItemDefinition)  
* [MyHudDefinition](Sandbox.Definitions.GUI.MyHudDefinition)  
* [MyLCDTextureDefinition](Sandbox.Definitions.MyLCDTextureDefinition)  
* [MyMainMenuInventorySceneDefinition](Sandbox.Definitions.MyMainMenuInventorySceneDefinition)  
* [MyOffensiveWordsDefinition](Sandbox.Definitions.MyOffensiveWordsDefinition)  
* [MyPhysicalItemDefinition](Sandbox.Definitions.MyPhysicalItemDefinition)  
* [MyPhysicalMaterialDefinition](Sandbox.Definitions.MyPhysicalMaterialDefinition)  
* [MyPhysicalModelCollectionDefinition](Sandbox.Definitions.MyPhysicalModelCollectionDefinition)  
* [MyPhysicalModelDefinition](Sandbox.Definitions.MyPhysicalModelDefinition)  
* [MyPirateAntennaDefinition](Sandbox.Definitions.MyPirateAntennaDefinition)  
* [MyPlanetGeneratorDefinition](Sandbox.Definitions.MyPlanetGeneratorDefinition)  
* [MyPlanetPrefabDefinition](Sandbox.Definitions.MyPlanetPrefabDefinition)  
* [MyPrefabDefinition](Sandbox.Definitions.MyPrefabDefinition)  
* [MyQuickStartDefinition](Sandbox.Definitions.MyQuickStartDefinition)  
* [MyReputationSettingsDefinition](VRage.Game.Definitions.Reputation.MyReputationSettingsDefinition)  
* [MyResearchBlockDefinition](Sandbox.Definitions.MyResearchBlockDefinition)  
* [MyResearchDefinition](Sandbox.Definitions.MyResearchDefinition)  
* [MyResearchGroupDefinition](Sandbox.Definitions.MyResearchGroupDefinition)  
* [MyResourceDistributionGroupDefinition](Sandbox.Definitions.MyResourceDistributionGroupDefinition)  
* [MyRespawnShipDefinition](Sandbox.Definitions.MyRespawnShipDefinition)  
* [MySafeZoneSettingsDefinition](VRage.Game.Definitions.MySafeZoneSettingsDefinition)  
* [MySafeZoneTexturesDefinition](VRage.Game.Definitions.MySafeZoneTexturesDefinition)  
* [MyScenarioCategoryDefinition](VRage.Game.Definitions.MyScenarioCategoryDefinition)  
* [MyScenarioDefinition](Sandbox.Definitions.MyScenarioDefinition)  
* [MyShipSoundsDefinition](Sandbox.Definitions.MyShipSoundsDefinition)  
* [MyShipSoundSystemDefinition](Sandbox.Definitions.MyShipSoundSystemDefinition)  
* [MySoundCategoryDefinition](Sandbox.Definitions.MySoundCategoryDefinition)  
* [MySpawnGroupDefinition](Sandbox.Definitions.MySpawnGroupDefinition)  
* [MyStationsListDefinition](Sandbox.Definitions.MyStationsListDefinition)  
* [MyStoryCategoryDefinition](Sandbox.Definitions.MyStoryCategoryDefinition)  
* [MyStoryDefinition](Sandbox.Definitions.MyStoryDefinition)  
* [MyTargetingGroupDefinition](Sandbox.Definitions.MyTargetingGroupDefinition)  
* [MyTransparentMaterialDefinition](Sandbox.Definitions.MyTransparentMaterialDefinition)  
* [MyVisualSettingsDefinition](VRage.Game.MyVisualSettingsDefinition)  
* [MyVoxelHandDefinition](Sandbox.Definitions.MyVoxelHandDefinition)  
* [MyVoxelMapStorageDefinition](Sandbox.Definitions.MyVoxelMapStorageDefinition)  
* [MyVoxelMaterialDefinition](VRage.Game.MyVoxelMaterialDefinition)  
* [MyVoxelMaterialModifierDefinition](Sandbox.Definitions.MyVoxelMaterialModifierDefinition)  
* [MyWeaponDefinition](Sandbox.Definitions.MyWeaponDefinition)  
* [MyWeatherEffectDefinition](Sandbox.Definitions.MyWeatherEffectDefinition)  
* [MyWheelModelsDefinition](VRage.Game.MyWheelModelsDefinition)

