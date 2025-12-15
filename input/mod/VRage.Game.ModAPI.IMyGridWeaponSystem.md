**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridWeaponSystem
```

ModAPI interface giving access to grid-group weapon system

## Methods

|Member|Description|
|---|---|
|[GetGun(MyDefinitionId)](VRage.Game.ModAPI.IMyGridWeaponSystem@GetGun)|Get first found gun object with specified definition id.|
|[Register(IMyGunObject<MyDeviceBase>)](VRage.Game.ModAPI.IMyGridWeaponSystem@Register)|Registers gun in weapon system. Required for being able to use it as a ship tool or weapon: `Left mouse hold to shoot`|
|[Unregister(IMyGunObject<MyDeviceBase>)](VRage.Game.ModAPI.IMyGridWeaponSystem@Unregister)|Unregisters gun in weapon system.|

