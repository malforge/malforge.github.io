**Assembly:** Sandbox.Game.dll

```csharp
public class MyAgentDefinition: MyBotDefinition
```

## Fields

|Member|Description|
|---|---|
|[AttackLength](Sandbox.Definitions.MyAgentDefinition@AttackLength)||
|[AttackRadius](Sandbox.Definitions.MyAgentDefinition@AttackRadius)||
|[AttackSound](Sandbox.Definitions.MyAgentDefinition@AttackSound)||
|[BotModel](Sandbox.Definitions.MyAgentDefinition@BotModel)||
|[CharacterDamage](Sandbox.Definitions.MyAgentDefinition@CharacterDamage)||
|[FactionTag](Sandbox.Definitions.MyAgentDefinition@FactionTag)||
|[GridDamage](Sandbox.Definitions.MyAgentDefinition@GridDamage)||
|[InventoryContainerTypeId](Sandbox.Definitions.MyAgentDefinition@InventoryContainerTypeId)||
|[InventoryContentGenerated](Sandbox.Definitions.MyAgentDefinition@InventoryContentGenerated)||
|[RemoveAfterDeath](Sandbox.Definitions.MyAgentDefinition@RemoveAfterDeath)||
|[RemoveTimeMs](Sandbox.Definitions.MyAgentDefinition@RemoveTimeMs)||
|[RespawnTimeMs](Sandbox.Definitions.MyAgentDefinition@RespawnTimeMs)||
|[TargetCharacters](Sandbox.Definitions.MyAgentDefinition@TargetCharacters)||
|[TargetGrids](Sandbox.Definitions.MyAgentDefinition@TargetGrids)||
|[TargetType](Sandbox.Definitions.MyAgentDefinition@TargetType)||
|[AvailableInSurvival](VRage.Game.MyDefinitionBase@AvailableInSurvival)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[BehaviorSubtype](Sandbox.Definitions.MyBotDefinition@BehaviorSubtype)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[BehaviorType](Sandbox.Definitions.MyBotDefinition@BehaviorType)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[BotBehaviorTree](Sandbox.Definitions.MyBotDefinition@BotBehaviorTree)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[Commandable](Sandbox.Definitions.MyBotDefinition@Commandable)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
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
|[TypeDefinitionId](Sandbox.Definitions.MyBotDefinition@TypeDefinitionId)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|

## Properties

|Member|Description|
|---|---|
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyAgentDefinition()](Sandbox.Definitions.MyAgentDefinition@.ctor)||
|[MyBotDefinition()](Sandbox.Definitions.MyBotDefinition@.ctor)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[AddItems(MyCharacter)](Sandbox.Definitions.MyAgentDefinition@AddItems)||
|[AddItems(MyCharacter)](Sandbox.Definitions.MyBotDefinition@AddItems)|_Inherited from [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)_|
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase) ˃ [MyBotDefinition](Sandbox.Definitions.MyBotDefinition)

**Inheritors:**  
* [MyAnimalBotDefinition](Sandbox.Definitions.MyAnimalBotDefinition)  
* [MyHumanoidBotDefinition](Sandbox.Definitions.MyHumanoidBotDefinition)

