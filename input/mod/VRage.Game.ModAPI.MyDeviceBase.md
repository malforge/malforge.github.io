**Assembly:** VRage.Game.dll

```csharp
public abstract class MyDeviceBase
```

Implements base abstract class for device

## Properties

|Member|Description|
|---|---|
|[InventoryItemId](VRage.Game.ModAPI.MyDeviceBase@InventoryItemId)|Reference to the inventory item that this device originated from. Can be used to update the inventory item (when ammo changes etc...)|

## Methods

|Member|Description|
|---|---|
|[CanSwitchAmmoMagazine()](VRage.Game.ModAPI.MyDeviceBase@CanSwitchAmmoMagazine)|Determines whether this device can switch ammo|
|[GetMuzzleLocalPosition()](VRage.Game.ModAPI.MyDeviceBase@GetMuzzleLocalPosition)|Gets the muzzle local position|
|[GetMuzzleWorldPosition()](VRage.Game.ModAPI.MyDeviceBase@GetMuzzleWorldPosition)|Gets the muzzle world position|
|[Init(MyObjectBuilder_DeviceBase)](VRage.Game.ModAPI.MyDeviceBase@Init)|Initialization of the device|
|[SwitchAmmoMagazineToNextAvailable()](VRage.Game.ModAPI.MyDeviceBase@SwitchAmmoMagazineToNextAvailable)|Switches to the next available ammo magazine|
|[SwitchToNextAmmoMagazine()](VRage.Game.ModAPI.MyDeviceBase@SwitchToNextAmmoMagazine)|Switches to the next ammo magazine|

**Inheritors:**  
* [MyGunBase](Sandbox.Game.Weapons.MyGunBase)  
* [MyToolBase](Sandbox.Game.Weapons.MyToolBase)

