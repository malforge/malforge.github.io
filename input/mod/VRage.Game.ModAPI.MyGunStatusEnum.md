**Assembly:** VRage.Game.dll

```csharp
public enum MyGunStatusEnum
```

When attempting to fire a gun, a status from this enum will be returned.

## Fields

|Member|Description|
|---|---|
|AccessDenied|Shooter does not not have access to the weapon|
|BurstLimit|whole burst fired, re-press the trigger|
|Cooldown|Gun is cooling down after previous shooting|
|Disabled|Gun is disabled by player|
|Failed|Any other reason not given here|
|NotCharged|Gun is charging energy|
|NotFunctional|Gun is damaged beyond functionality|
|NotSelected|No gun was selected, so nothing could shoot|
|OK|Gun is capable of shooting|
|OutOfAmmo|Gun does not have ammo|
|OutOfPower|Gun does not have enough power to shoot|
|Reloading|Gun currently reloading|
|SafeZoneDenied|Disabled in safezone|

