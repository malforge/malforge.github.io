**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyMissileGunObject: IMyGunObject<MyGunBase>, IMyShootOrigin
```

## Properties

|Member|Description|
|---|---|
|[GetAmmoDefinition](Sandbox.ModAPI.IMyShootOrigin@GetAmmoDefinition)|Gets ammo definition<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[MaxShootRange](Sandbox.ModAPI.IMyShootOrigin@MaxShootRange)|Gets weapon max shoot range<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[ShootOrigin](Sandbox.ModAPI.IMyShootOrigin@ShootOrigin)|Gets shot starting position<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|

## Methods

|Member|Description|
|---|---|
|[RemoveMissile(long)](Sandbox.Game.Entities.IMyMissileGunObject@RemoveMissile)||
|[ShootMissile(MyObjectBuilder_Missile)](Sandbox.Game.Entities.IMyMissileGunObject@ShootMissile)||

**Implements:**  
* [IMyGunObject<MyGunBase>](VRage.Game.ModAPI.IMyGunObject{MyGunBase})  
* [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)

