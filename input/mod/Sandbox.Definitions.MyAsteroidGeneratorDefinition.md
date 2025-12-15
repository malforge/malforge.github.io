**Assembly:** Sandbox.Game.dll

```csharp
public class MyAsteroidGeneratorDefinition: MyDefinitionBase
```

## Fields

|Member|Description|
|---|---|
|[AllowPartialClusterObjectOverlap](Sandbox.Definitions.MyAsteroidGeneratorDefinition@AllowPartialClusterObjectOverlap)|Allows objects in clusters to partially overlap (in terms of their AABBs)|
|[ClusterDispersionAbsolute](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ClusterDispersionAbsolute)|Enables absolute positioning in cluster|
|[ObjectDensityCluster](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectDensityCluster)|Probability that generated object in cluster will be used|
|[ObjectMaxDistanceInClusterMax](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectMaxDistanceInClusterMax)||
|[ObjectMaxDistanceInClusterMin](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectMaxDistanceInClusterMin)||
|[ObjectMaxInCluster](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectMaxInCluster)|Maximal number of asteroids per cluster|
|[ObjectMinDistanceInCluster](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectMinDistanceInCluster)|Controls positional dispersion of cluster objects. Behavior is controlled by [ClusterDispersionAbsolute](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ClusterDispersionAbsolute) |
|[ObjectSizeMax](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectSizeMax)|Maximal size of lone asteroids|
|[ObjectSizeMaxCluster](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectSizeMaxCluster)|Maximal size of individual cluster asteroids|
|[ObjectSizeMin](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectSizeMin)|Minimal size of lone asteroids|
|[ObjectSizeMinCluster](Sandbox.Definitions.MyAsteroidGeneratorDefinition@ObjectSizeMinCluster)|Minimal size of individual cluster asteroids|
|[RotateAsteroids](Sandbox.Definitions.MyAsteroidGeneratorDefinition@RotateAsteroids)|Enable asteroid rotation|
|[SeedClusterTypeProbability](Sandbox.Definitions.MyAsteroidGeneratorDefinition@SeedClusterTypeProbability)||
|[SeedTypeProbability](Sandbox.Definitions.MyAsteroidGeneratorDefinition@SeedTypeProbability)||
|[SubCells](Sandbox.Definitions.MyAsteroidGeneratorDefinition@SubCells)||
|[SubcellSize](Sandbox.Definitions.MyAsteroidGeneratorDefinition@SubcellSize)||
|[UseClusterDefAsAsteroid](Sandbox.Definitions.MyAsteroidGeneratorDefinition@UseClusterDefAsAsteroid)|Backwards comp for incorrect cluster object size|
|[UseClusterVariableSize](Sandbox.Definitions.MyAsteroidGeneratorDefinition@UseClusterVariableSize)||
|[UseGeneratorSeed](Sandbox.Definitions.MyAsteroidGeneratorDefinition@UseGeneratorSeed)||
|[UseLinearPowOfTwoSizeDistribution](Sandbox.Definitions.MyAsteroidGeneratorDefinition@UseLinearPowOfTwoSizeDistribution)||
|[Version](Sandbox.Definitions.MyAsteroidGeneratorDefinition@Version)||
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
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyAsteroidGeneratorDefinition()](Sandbox.Definitions.MyAsteroidGeneratorDefinition@.ctor)||
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase)

