**Assembly:** Sandbox.Game.dll

```csharp
public class MyWeaponDefinition: MyDefinitionBase
```

## Fields

|Member|Description|
|---|---|
|[AmmoMagazinesId](Sandbox.Definitions.MyWeaponDefinition@AmmoMagazinesId)||
|[DamageMultiplier](Sandbox.Definitions.MyWeaponDefinition@DamageMultiplier)||
|[DeviateShotAngle](Sandbox.Definitions.MyWeaponDefinition@DeviateShotAngle)||
|[DeviateShotAngleAiming](Sandbox.Definitions.MyWeaponDefinition@DeviateShotAngleAiming)||
|[EquipDuration](Sandbox.Definitions.MyWeaponDefinition@EquipDuration)||
|[MaximumTimeBetweenIdleRotationsMs](Sandbox.Definitions.MyWeaponDefinition@MaximumTimeBetweenIdleRotationsMs)||
|[MinimumTimeBetweenIdleRotationsMs](Sandbox.Definitions.MyWeaponDefinition@MinimumTimeBetweenIdleRotationsMs)||
|[MuzzleFlashLifeSpan](Sandbox.Definitions.MyWeaponDefinition@MuzzleFlashLifeSpan)||
|[NoAmmoSound](Sandbox.Definitions.MyWeaponDefinition@NoAmmoSound)||
|[PhysicalMaterial](Sandbox.Definitions.MyWeaponDefinition@PhysicalMaterial)||
|[RangeMultiplier](Sandbox.Definitions.MyWeaponDefinition@RangeMultiplier)||
|[RecoilGroundHorizontal](Sandbox.Definitions.MyWeaponDefinition@RecoilGroundHorizontal)||
|[RecoilGroundVertical](Sandbox.Definitions.MyWeaponDefinition@RecoilGroundVertical)||
|[RecoilJetpackHorizontal](Sandbox.Definitions.MyWeaponDefinition@RecoilJetpackHorizontal)||
|[RecoilJetpackVertical](Sandbox.Definitions.MyWeaponDefinition@RecoilJetpackVertical)||
|[RecoilMultiplierData](Sandbox.Definitions.MyWeaponDefinition@RecoilMultiplierData)||
|[RecoilResetTimeMilliseconds](Sandbox.Definitions.MyWeaponDefinition@RecoilResetTimeMilliseconds)||
|[ReleaseTimeAfterFire](Sandbox.Definitions.MyWeaponDefinition@ReleaseTimeAfterFire)||
|[ReloadSound](Sandbox.Definitions.MyWeaponDefinition@ReloadSound)||
|[ReloadTime](Sandbox.Definitions.MyWeaponDefinition@ReloadTime)||
|[SecondarySound](Sandbox.Definitions.MyWeaponDefinition@SecondarySound)||
|[ShakeOnAction](Sandbox.Definitions.MyWeaponDefinition@ShakeOnAction)||
|[ShootDirectionUpdateTime](Sandbox.Definitions.MyWeaponDefinition@ShootDirectionUpdateTime)||
|[ShotDelay](Sandbox.Definitions.MyWeaponDefinition@ShotDelay)|Working only for MissileLauncher|
|[SupportReloading](Sandbox.Definitions.MyWeaponDefinition@SupportReloading)||
|[UseDefaultMuzzleFlash](Sandbox.Definitions.MyWeaponDefinition@UseDefaultMuzzleFlash)||
|[UseRandomizedRange](Sandbox.Definitions.MyWeaponDefinition@UseRandomizedRange)||
|[WeaponAmmoDatas](Sandbox.Definitions.MyWeaponDefinition@WeaponAmmoDatas)||
|[WeaponEffects](Sandbox.Definitions.MyWeaponDefinition@WeaponEffects)||
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
|[HasMissileAmmoDefined](Sandbox.Definitions.MyWeaponDefinition@HasMissileAmmoDefined)||
|[HasProjectileAmmoDefined](Sandbox.Definitions.MyWeaponDefinition@HasProjectileAmmoDefined)||
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyWeaponDefinition()](Sandbox.Definitions.MyWeaponDefinition@.ctor)||
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[GetAmmoMagazineIdArrayIndex(MyDefinitionId)](Sandbox.Definitions.MyWeaponDefinition@GetAmmoMagazineIdArrayIndex)||
|[HasAmmoMagazines()](Sandbox.Definitions.MyWeaponDefinition@HasAmmoMagazines)||
|[HasSpecificAmmoData(MyAmmoDefinition)](Sandbox.Definitions.MyWeaponDefinition@HasSpecificAmmoData)||
|[IsAmmoMagazineCompatible(MyDefinitionId)](Sandbox.Definitions.MyWeaponDefinition@IsAmmoMagazineCompatible)||
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase)

