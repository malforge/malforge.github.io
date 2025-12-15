**Assembly:** VRage.Game.dll

```csharp
public class MyVoxelMaterialDefinition: MyDefinitionBase
```

## Fields

|Member|Description|
|---|---|
|[AsteroidGeneratorSpawnProbabilityMultiplier](VRage.Game.MyVoxelMaterialDefinition@AsteroidGeneratorSpawnProbabilityMultiplier)||
|[BareVariant](VRage.Game.MyVoxelMaterialDefinition@BareVariant)||
|[CanBeHarvested](VRage.Game.MyVoxelMaterialDefinition@CanBeHarvested)||
|[ColorKey](VRage.Game.MyVoxelMaterialDefinition@ColorKey)||
|[DamagedMaterial](VRage.Game.MyVoxelMaterialDefinition@DamagedMaterial)||
|[Friction](VRage.Game.MyVoxelMaterialDefinition@Friction)||
|[IsRare](VRage.Game.MyVoxelMaterialDefinition@IsRare)||
|[LandingEffect](VRage.Game.MyVoxelMaterialDefinition@LandingEffect)||
|[MaterialTypeName](VRage.Game.MyVoxelMaterialDefinition@MaterialTypeName)||
|[MaxVersion](VRage.Game.MyVoxelMaterialDefinition@MaxVersion)||
|[MinedOre](VRage.Game.MyVoxelMaterialDefinition@MinedOre)||
|[MinedOreRatio](VRage.Game.MyVoxelMaterialDefinition@MinedOreRatio)||
|[MinVersion](VRage.Game.MyVoxelMaterialDefinition@MinVersion)||
|[RenderParams](VRage.Game.MyVoxelMaterialDefinition@RenderParams)||
|[Restitution](VRage.Game.MyVoxelMaterialDefinition@Restitution)||
|[SpawnsFromMeteorites](VRage.Game.MyVoxelMaterialDefinition@SpawnsFromMeteorites)||
|[SpawnsInAsteroids](VRage.Game.MyVoxelMaterialDefinition@SpawnsInAsteroids)||
|[VoxelHandPreview](VRage.Game.MyVoxelMaterialDefinition@VoxelHandPreview)||
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
|[HasDamageMaterial](VRage.Game.MyVoxelMaterialDefinition@HasDamageMaterial)||
|[Icon](VRage.Game.MyVoxelMaterialDefinition@Icon)||
|[Index](VRage.Game.MyVoxelMaterialDefinition@Index)|Value generated at runtime to ensure correctness. Do not serialize or deserialize. This is what the old cast to int used to result into, but now numbers depend on order in XML file. TODO Serialize to XML and ensure upon loading that these values are starting from 0 and continuous.|
|[MaterialTypeNameHash](VRage.Game.MyVoxelMaterialDefinition@MaterialTypeNameHash)||
|[MaterialTypeNameId](VRage.Game.MyVoxelMaterialDefinition@MaterialTypeNameId)||
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyVoxelMaterialDefinition()](VRage.Game.MyVoxelMaterialDefinition@.ctor)||
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[static ResetIndexing()](VRage.Game.MyVoxelMaterialDefinition@ResetIndexing)||
|[AssignIndex()](VRage.Game.MyVoxelMaterialDefinition@AssignIndex)||
|[GetObjectBuilder()](VRage.Game.MyVoxelMaterialDefinition@GetObjectBuilder)||
|[UpdateVoxelMaterial()](VRage.Game.MyVoxelMaterialDefinition@UpdateVoxelMaterial)||
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase)

**Inheritors:**  
* [MyDx11VoxelMaterialDefinition](Sandbox.Definitions.MyDx11VoxelMaterialDefinition)

