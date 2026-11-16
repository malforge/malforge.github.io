**Assembly:** Sandbox.Game.dll

```csharp
public class MyMissileAmmoDefinition: MyAmmoDefinition
```

## Fields

|Member|Description|
|---|---|
|[static MINIMAL_EXPLOSION_RADIUS](Sandbox.Definitions.MyMissileAmmoDefinition@MINIMAL_EXPLOSION_RADIUS)||
|[CanBeTargeted](Sandbox.Definitions.MyMissileAmmoDefinition@CanBeTargeted)|Whether turrets running with the Target Missiles option on may pick this ammo as a target. Turn it off for ammo that only nominally is a missile - slugs and cannon shells - so turrets keep shooting at real threats.|
|[CanDistract](Sandbox.Definitions.MyMissileAmmoDefinition@CanDistract)||
|[CanSeek](Sandbox.Definitions.MyMissileAmmoDefinition@CanSeek)||
|[CanSeekCharacters](Sandbox.Definitions.MyMissileAmmoDefinition@CanSeekCharacters)|Whether a character may be inherited as this ammo's homing target. Off means a locked character is not a usable target: the missile is dumb-fired, and a launcher with Require Target Lock refuses the shot.|
|[CountermeasureResilience](Sandbox.Definitions.MyMissileAmmoDefinition@CountermeasureResilience)||
|[EnforceConeOnLaunch](Sandbox.Definitions.MyMissileAmmoDefinition@EnforceConeOnLaunch)||
|[ExplosionFlags](Sandbox.Definitions.MyMissileAmmoDefinition@ExplosionFlags)||
|[Guidance](Sandbox.Definitions.MyMissileAmmoDefinition@Guidance)||
|[GuidanceRange](Sandbox.Definitions.MyMissileAmmoDefinition@GuidanceRange)||
|[Integrity](Sandbox.Definitions.MyMissileAmmoDefinition@Integrity)||
|[Lifetime](Sandbox.Definitions.MyMissileAmmoDefinition@Lifetime)|Seconds before the missile self-destructs regardless of distance; 0 disables the timer, leaving MaxTrajectory as the only range limit.|
|[LockMaintainConeDegrees](Sandbox.Definitions.MyMissileAmmoDefinition@LockMaintainConeDegrees)||
|[LockOnConeDegrees](Sandbox.Definitions.MyMissileAmmoDefinition@LockOnConeDegrees)||
|[MaxLaunchOffAxisDegrees](Sandbox.Definitions.MyMissileAmmoDefinition@MaxLaunchOffAxisDegrees)|Widest angle between the launcher's forward and the target at which an AI combat block may still fire this ammo, in degrees; 0 keeps the attack pattern's own firing angle. Only seeking ammo can convert an off-axis launch into a hit, so keep it within what MaxTurnRateDegreesPerSecond and Lifetime can actually recover.|
|[MaxTurnRateDegreesPerSecond](Sandbox.Definitions.MyMissileAmmoDefinition@MaxTurnRateDegreesPerSecond)||
|[MissileAcceleration](Sandbox.Definitions.MyMissileAmmoDefinition@MissileAcceleration)||
|[MissileExplosionDamage](Sandbox.Definitions.MyMissileAmmoDefinition@MissileExplosionDamage)||
|[MissileExplosionRadius](Sandbox.Definitions.MyMissileAmmoDefinition@MissileExplosionRadius)||
|[MissileGravityEnabled](Sandbox.Definitions.MyMissileAmmoDefinition@MissileGravityEnabled)||
|[MissileHealthPool](Sandbox.Definitions.MyMissileAmmoDefinition@MissileHealthPool)||
|[MissileInitialSpeed](Sandbox.Definitions.MyMissileAmmoDefinition@MissileInitialSpeed)||
|[MissileMass](Sandbox.Definitions.MyMissileAmmoDefinition@MissileMass)||
|[MissileMaxRicochetAngle](Sandbox.Definitions.MyMissileAmmoDefinition@MissileMaxRicochetAngle)||
|[MissileMaxRicochetProbability](Sandbox.Definitions.MyMissileAmmoDefinition@MissileMaxRicochetProbability)||
|[MissileMinRicochetAngle](Sandbox.Definitions.MyMissileAmmoDefinition@MissileMinRicochetAngle)||
|[MissileMinRicochetProbability](Sandbox.Definitions.MyMissileAmmoDefinition@MissileMinRicochetProbability)||
|[MissileModelName](Sandbox.Definitions.MyMissileAmmoDefinition@MissileModelName)||
|[MissilePreserveLaunchMomentum](Sandbox.Definitions.MyMissileAmmoDefinition@MissilePreserveLaunchMomentum)|Keeps momentum inherited from the launching grid out of the missile's heading: the nose is not snapped onto the travel direction while that momentum dominates, and the velocity is swung onto the nose at MaxTurnRateDegreesPerSecond instead of instantly. Required by ammo whose MissileInitialSpeed is well below grid speeds. Not for ammo relying on MissileGravityEnabled, whose arc the velocity turn would cancel out.|
|[MissileRicochetDamage](Sandbox.Definitions.MyMissileAmmoDefinition@MissileRicochetDamage)||
|[MissileSkipAcceleration](Sandbox.Definitions.MyMissileAmmoDefinition@MissileSkipAcceleration)||
|[MissileTrailEffect](Sandbox.Definitions.MyMissileAmmoDefinition@MissileTrailEffect)||
|[SeekDelay](Sandbox.Definitions.MyMissileAmmoDefinition@SeekDelay)||
|[AmmoType](Sandbox.Definitions.MyAmmoDefinition@AmmoType)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[AvailableInSurvival](VRage.Game.MyDefinitionBase@AvailableInSurvival)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[BackkickForce](Sandbox.Definitions.MyAmmoDefinition@BackkickForce)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[Context](VRage.Game.MyDefinitionBase@Context)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DeathMessage](Sandbox.Definitions.MyAmmoDefinition@DeathMessage)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[DescriptionArgs](VRage.Game.MyDefinitionBase@DescriptionArgs)|String used for shortcuts used in description<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionEnum](VRage.Game.MyDefinitionBase@DescriptionEnum)|Enum used for localization of description. Null for player created definitions.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DescriptionString](VRage.Game.MyDefinitionBase@DescriptionString)|String used for user created description which do not have localization support.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DesiredSpeed](Sandbox.Definitions.MyAmmoDefinition@DesiredSpeed)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[Enabled](VRage.Game.MyDefinitionBase@Enabled)|Definition can be disabled by mod, then it will be removed from definition manager<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[EndOfLifeEffect](Sandbox.Definitions.MyAmmoDefinition@EndOfLifeEffect)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[EndOfLifeSound](Sandbox.Definitions.MyAmmoDefinition@EndOfLifeSound)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[ExplosiveDamageMultiplier](Sandbox.Definitions.MyAmmoDefinition@ExplosiveDamageMultiplier)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[Icons](VRage.Game.MyDefinitionBase@Icons)|Icons for the definition, they are used from top to bottom.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Id](VRage.Game.MyDefinitionBase@Id)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[IsExplosive](Sandbox.Definitions.MyAmmoDefinition@IsExplosive)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[MaxTrajectory](Sandbox.Definitions.MyAmmoDefinition@MaxTrajectory)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[PhysicalMaterial](Sandbox.Definitions.MyAmmoDefinition@PhysicalMaterial)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[Public](VRage.Game.MyDefinitionBase@Public)|Indicates if definition should be offered in Cube builder<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[SpeedVar](Sandbox.Definitions.MyAmmoDefinition@SpeedVar)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|

## Properties

|Member|Description|
|---|---|
|[DescriptionText](VRage.Game.MyDefinitionBase@DescriptionText)|Use this property when showing description in GUI, as it takes into account more complex description construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameEnum](VRage.Game.MyDefinitionBase@DisplayNameEnum)|Enum used for localization of display name. Null for player created definitions.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameString](VRage.Game.MyDefinitionBase@DisplayNameString)|String name used for user created definitions which do not have localization support.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DisplayNameText](VRage.Game.MyDefinitionBase@DisplayNameText)|Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[DLCs](VRage.Game.MyDefinitionBase@DLCs)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyMissileAmmoDefinition()](Sandbox.Definitions.MyMissileAmmoDefinition@.ctor)||
|[MyDefinitionBase()](VRage.Game.MyDefinitionBase@.ctor)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[GetDamageForMechanicalObjects()](Sandbox.Definitions.MyMissileAmmoDefinition@GetDamageForMechanicalObjects)||
|[CheckDefinitionDLCs(String[])](VRage.Game.MyDefinitionBase@CheckDefinitionDLCs)|Checks if the definition has all required DLCs as it should have<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[GetDamageForMechanicalObjects()](Sandbox.Definitions.MyAmmoDefinition@GetDamageForMechanicalObjects)|_Inherited from [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)_|
|[GetObjectBuilder()](VRage.Game.MyDefinitionBase@GetObjectBuilder)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Init(MyObjectBuilder_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase@Init)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[Postprocess()](VRage.Game.MyDefinitionBase@Postprocess)|Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,<br /><br />but you only want to do it when all the definitions are loaded and merged.<br /><br />_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|
|[ToString()](VRage.Game.MyDefinitionBase@ToString)|_Inherited from [MyDefinitionBase](VRage.Game.MyDefinitionBase)_|

**Inheritance:**   [MyDefinitionBase](VRage.Game.MyDefinitionBase) ˃ [MyAmmoDefinition](Sandbox.Definitions.MyAmmoDefinition)

