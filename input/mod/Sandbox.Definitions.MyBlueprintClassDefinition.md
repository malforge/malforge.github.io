**Assembly:** Sandbox.Game.dll

```csharp
public class MyBlueprintClassDefinition: MyDefinitionBase, IEnumerable<MyBlueprintDefinitionBase>, IEnumerable
```

## Fields

|Member|Description|
|---|---|
|[FocusIcon](Sandbox.Definitions.MyBlueprintClassDefinition@FocusIcon)||
|[HighlightIcon](Sandbox.Definitions.MyBlueprintClassDefinition@HighlightIcon)||
|[InputConstraintDescription](Sandbox.Definitions.MyBlueprintClassDefinition@InputConstraintDescription)||
|[InputConstraintIcon](Sandbox.Definitions.MyBlueprintClassDefinition@InputConstraintIcon)||
|[OutputConstraintDescription](Sandbox.Definitions.MyBlueprintClassDefinition@OutputConstraintDescription)||
|[OutputConstraintIcon](Sandbox.Definitions.MyBlueprintClassDefinition@OutputConstraintIcon)||
|[ProgressBarSoundCue](Sandbox.Definitions.MyBlueprintClassDefinition@ProgressBarSoundCue)||
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
|[MyBlueprintClassDefinition()](Sandbox.Definitions.MyBlueprintClassDefinition@.ctor)||
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[AddBlueprint(MyBlueprintDefinitionBase)](Sandbox.Definitions.MyBlueprintClassDefinition@AddBlueprint)||
|[ClearBlueprints()](Sandbox.Definitions.MyBlueprintClassDefinition@ClearBlueprints)||
|[ContainsBlueprint(MyBlueprintDefinitionBase)](Sandbox.Definitions.MyBlueprintClassDefinition@ContainsBlueprint)||
|[GetEnumerator()](Sandbox.Definitions.MyBlueprintClassDefinition@GetEnumerator)||
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase)

**Implements:**  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable<MyBlueprintDefinitionBase>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

