**Assembly:** VRage.Game.dll

```csharp
public interface IMyModAPINaturalGravityComponent: IMyNaturalGravityComponent
```

Describes ModAPI any form natural gravity provider (any form, not only sphere)

## Properties

|Member|Description|
|---|---|
|[Implementation](VRage.Game.ModAPI.IMyModAPINaturalGravityComponent@Implementation)|Gets implementation of gravity provider|
|[GravityLimit](VRage.Game.ModAPI.IMyNaturalGravityComponent@GravityLimit)|Gets distance between Position of gravity provider, and it's most distant point<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[IsWorking](VRage.Game.ModAPI.IMyNaturalGravityComponent@IsWorking)|Gets whither block is working or not<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[Position](VRage.Game.ModAPI.IMyNaturalGravityComponent@Position)|_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|

## Methods

|Member|Description|
|---|---|
|[GetGravityMultiplier(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetGravityMultiplier)|Get gravity scalar<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[GetProxyAABB(out BoundingBoxD)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetProxyAABB)|Get bounding box around gravity provider<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[GetWorldGravity(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetWorldGravity)|Gets gravity vector<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[IsPositionInRange(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@IsPositionInRange)|Tests if the specified point is within the gravity of this entity.<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|

**Implements:**  
* [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)

**Inheritors:**  
* [MyModAPINaturalGravityComponent](Sandbox.Game.Entities.MyModAPINaturalGravityComponent)

