**Assembly:** Sandbox.Game.dll

```csharp
public class MyToolBase: MyDeviceBase
```

## Properties

|Member|Description|
|---|---|
|[InventoryItemId](VRage.Game.ModAPI.MyDeviceBase@InventoryItemId)|Reference to the inventory item that this device originated from. Can be used to update the inventory item (when ammo changes etc...)<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyToolBase()](Sandbox.Game.Weapons.MyToolBase@.ctor)||
|[MyToolBase(Vector3, MatrixD)](Sandbox.Game.Weapons.MyToolBase@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CanSwitchAmmoMagazine()](Sandbox.Game.Weapons.MyToolBase@CanSwitchAmmoMagazine)||
|[GetMuzzleLocalPosition()](Sandbox.Game.Weapons.MyToolBase@GetMuzzleLocalPosition)||
|[GetMuzzleWorldPosition()](Sandbox.Game.Weapons.MyToolBase@GetMuzzleWorldPosition)||
|[GetObjectBuilder()](Sandbox.Game.Weapons.MyToolBase@GetObjectBuilder)||
|[Init(MyObjectBuilder_ToolBase)](Sandbox.Game.Weapons.MyToolBase@Init)||
|[OnWorldPositionChanged(MatrixD)](Sandbox.Game.Weapons.MyToolBase@OnWorldPositionChanged)||
|[SwitchAmmoMagazineToNextAvailable()](Sandbox.Game.Weapons.MyToolBase@SwitchAmmoMagazineToNextAvailable)||
|[SwitchToNextAmmoMagazine()](Sandbox.Game.Weapons.MyToolBase@SwitchToNextAmmoMagazine)||
|[CanSwitchAmmoMagazine()](VRage.Game.ModAPI.MyDeviceBase@CanSwitchAmmoMagazine)|Determines whether this device can switch ammo<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[GetMuzzleLocalPosition()](VRage.Game.ModAPI.MyDeviceBase@GetMuzzleLocalPosition)|Gets the muzzle local position<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[GetMuzzleWorldPosition()](VRage.Game.ModAPI.MyDeviceBase@GetMuzzleWorldPosition)|Gets the muzzle world position<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[Init(MyObjectBuilder_DeviceBase)](VRage.Game.ModAPI.MyDeviceBase@Init)|Initialization of the device<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[SwitchAmmoMagazineToNextAvailable()](VRage.Game.ModAPI.MyDeviceBase@SwitchAmmoMagazineToNextAvailable)|Switches to the next available ammo magazine<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[SwitchToNextAmmoMagazine()](VRage.Game.ModAPI.MyDeviceBase@SwitchToNextAmmoMagazine)|Switches to the next ammo magazine<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|

**Inheritance:**   [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)

