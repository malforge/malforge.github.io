**Assembly:** VRage.Game.dll

```csharp
public interface IMySphericalNaturalGravityComponent: IMyNaturalGravityComponent
```

Describes spherical natural gravity provider

## Properties

|Member|Description|
|---|---|
|[Falloff](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@Falloff)|Gravity falloff between minRadius and maxRadius|
|[Intensity](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@Intensity)|Gravity strength|
|[MaxRadius](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@MaxRadius)|Max gravity radius at lowest intensity|
|[MinRadius](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@MinRadius)|Minimum gravity radius before gravity intensity begins to decrease|
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
* [MySphericalNaturalGravityComponent](Sandbox.Game.Entities.MySphericalNaturalGravityComponent)

