**Assembly:** VRage.Game.dll

```csharp
public class MyDlcDefinition: MyDefinitionBase, IMyDLC
```

## Fields

|Member|Description|
|---|---|
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
|[AppId](VRage.Game.Definitions.MyDlcDefinition@AppId)||
|[Badge](VRage.Game.Definitions.MyDlcDefinition@Badge)|Badge of the DLC, to be displayed in main menu|
|[Description](VRage.Game.Definitions.MyDlcDefinition@Description)|Description of the DLC, preferably a localized string|
|[DisplayName](VRage.Game.Definitions.MyDlcDefinition@DisplayName)|Name of the DLC, preferably a localized string|
|[Icon](VRage.Game.Definitions.MyDlcDefinition@Icon)|Icon of the DLC, to be displayed in G-screen, blueprints, etc ...|
|[Name](VRage.Game.Definitions.MyDlcDefinition@Name)||
|[Ps4ProductIds](VRage.Game.Definitions.MyDlcDefinition@Ps4ProductIds)||
|[Ps5ProductIds](VRage.Game.Definitions.MyDlcDefinition@Ps5ProductIds)||
|[XboxPackageId](VRage.Game.Definitions.MyDlcDefinition@XboxPackageId)||
|[XboxStoreId](VRage.Game.Definitions.MyDlcDefinition@XboxStoreId)||
|[AppId](VRage.Game.ModAPI.IMyDLC@AppId)|Gets the Steam AppID of the DLC.<br /><br />_Inherited from [IMyDLC](VRage.Game.ModAPI.IMyDLC)_|
|[Badge](VRage.Game.ModAPI.IMyDLC@Badge)|Gets badge of the DLC. Displayed in main menu.<br /><br />_Inherited from [IMyDLC](VRage.Game.ModAPI.IMyDLC)_|
|[Description](VRage.Game.ModAPI.IMyDLC@Description)|Gets localized description of the DLC.<br /><br />_Inherited from [IMyDLC](VRage.Game.ModAPI.IMyDLC)_|
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayName](VRage.Game.ModAPI.IMyDLC@DisplayName)|Gets localized name of the DLC.<br /><br />_Inherited from [IMyDLC](VRage.Game.ModAPI.IMyDLC)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Icon](VRage.Game.ModAPI.IMyDLC@Icon)|Gets icon of the DLC. Displayed in G-screen, blueprints, etc ...<br /><br />_Inherited from [IMyDLC](VRage.Game.ModAPI.IMyDLC)_|
|[Name](VRage.Game.ModAPI.IMyDLC@Name)|Gets the internal name of the DLC. This is the name used in CubeBlocks.sbc, for example.<br /><br />_Inherited from [IMyDLC](VRage.Game.ModAPI.IMyDLC)_|

## Constructors

|Member|Description|
|---|---|
|[MyDlcDefinition()](VRage.Game.Definitions.MyDlcDefinition@.ctor)||
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

**Implements:**  
* [IMyDLC](VRage.Game.ModAPI.IMyDLC)

