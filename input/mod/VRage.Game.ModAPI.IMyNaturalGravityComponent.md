**Assembly:** VRage.Game.dll

```csharp
public interface IMyNaturalGravityComponent
```

Describes natural gravity provider It may be [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent) or [IMyModAPINaturalGravityImplementation](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation) 

## Properties

|Member|Description|
|---|---|
|[GravityLimit](VRage.Game.ModAPI.IMyNaturalGravityComponent@GravityLimit)|Gets distance between Position of gravity provider, and it's most distant point|
|[IsWorking](VRage.Game.ModAPI.IMyNaturalGravityComponent@IsWorking)|Gets whither block is working or not|
|[Position](VRage.Game.ModAPI.IMyNaturalGravityComponent@Position)||

## Methods

|Member|Description|
|---|---|
|[GetGravityMultiplier(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetGravityMultiplier)|Get gravity scalar|
|[GetProxyAABB(out BoundingBoxD)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetProxyAABB)|Get bounding box around gravity provider|
|[GetWorldGravity(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetWorldGravity)|Gets gravity vector|
|[IsPositionInRange(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@IsPositionInRange)|Tests if the specified point is within the gravity of this entity.|

**Inheritors:**  
* [IMyModAPINaturalGravityComponent](VRage.Game.ModAPI.IMyModAPINaturalGravityComponent)  
* [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent)  
* [MyModAPINaturalGravityComponent](Sandbox.Game.Entities.MyModAPINaturalGravityComponent)  
* [MySphericalNaturalGravityComponent](Sandbox.Game.Entities.MySphericalNaturalGravityComponent)

