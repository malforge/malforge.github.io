**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyGravityProvider
```

## Properties

|Member|Description|
|---|---|
|[IsWorking](Sandbox.Game.Entities.IMyGravityProvider@IsWorking)||

## Methods

|Member|Description|
|---|---|
|[GetGravityMultiplier(Vector3D)](Sandbox.Game.Entities.IMyGravityProvider@GetGravityMultiplier)||
|[GetProxyAABB(out BoundingBoxD)](Sandbox.Game.Entities.IMyGravityProvider@GetProxyAABB)||
|[GetWorldGravity(Vector3D)](Sandbox.Game.Entities.IMyGravityProvider@GetWorldGravity)||
|[IsPositionInRange(Vector3D)](Sandbox.Game.Entities.IMyGravityProvider@IsPositionInRange)|Tests if the specified point is within the gravity of this entity.|

**Inheritors:**  
* [IMyGravityGenerator](SpaceEngineers.Game.ModAPI.IMyGravityGenerator)  
* [IMyGravityGeneratorBase](SpaceEngineers.Game.ModAPI.IMyGravityGeneratorBase)  
* [IMyGravityGeneratorSphere](SpaceEngineers.Game.ModAPI.IMyGravityGeneratorSphere)  
* [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)  
* [MyModAPINaturalGravityComponent](Sandbox.Game.Entities.MyModAPINaturalGravityComponent)  
* [MySphericalNaturalGravityComponent](Sandbox.Game.Entities.MySphericalNaturalGravityComponent)

