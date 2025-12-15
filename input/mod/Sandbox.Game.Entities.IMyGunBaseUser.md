**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyGunBaseUser
```

## Properties

|Member|Description|
|---|---|
|[AmmoInventory](Sandbox.Game.Entities.IMyGunBaseUser@AmmoInventory)|The inventory in which the weapon searches for additional ammo|
|[ConstraintDisplayName](Sandbox.Game.Entities.IMyGunBaseUser@ConstraintDisplayName)||
|[IgnoreEntities](Sandbox.Game.Entities.IMyGunBaseUser@IgnoreEntities)||
|[Launcher](Sandbox.Game.Entities.IMyGunBaseUser@Launcher)||
|[Owner](Sandbox.Game.Entities.IMyGunBaseUser@Owner)||
|[OwnerId](Sandbox.Game.Entities.IMyGunBaseUser@OwnerId)||
|[PhysicalItemId](Sandbox.Game.Entities.IMyGunBaseUser@PhysicalItemId)|The physical item that is being searched for in the weapon inventory. Can be ignored if WeaponInventory is null|
|[Weapon](Sandbox.Game.Entities.IMyGunBaseUser@Weapon)||
|[WeaponInventory](Sandbox.Game.Entities.IMyGunBaseUser@WeaponInventory)|The inventory in which the weapon searches for it's object builder (e.g. an automatic rifle in character's inventory) Can be null if the object builder is not to be searched|

**Inheritors:**  
* [IMyAutomaticRifleGun](Sandbox.ModAPI.Weapons.IMyAutomaticRifleGun)  
* [IMyHandDrill](Sandbox.ModAPI.Weapons.IMyHandDrill)

