**Assembly:** VRage.Game.dll

```csharp
public interface IMyGravityProviderSystem
```

Describes gravity ModAPI

## Methods

|Member|Description|
|---|---|
|[AddNaturalGravity(Vector3D, double, double, double, double)](VRage.Game.ModAPI.IMyGravityProviderSystem@AddNaturalGravity)|Adds natural gravity to a position.|
|[AddNaturalGravityToEntity(IMyEntity, double, double, double, double)](VRage.Game.ModAPI.IMyGravityProviderSystem@AddNaturalGravityToEntity)|Adds natural gravity to an entity.|
|[AddNaturalModAPI(Vector3D, IMyModAPINaturalGravityImplementation)](VRage.Game.ModAPI.IMyGravityProviderSystem@AddNaturalModAPI)|Adds natural gravity to a position.|
|[AddNaturalModAPIGravityToEntity(IMyEntity, IMyModAPINaturalGravityImplementation)](VRage.Game.ModAPI.IMyGravityProviderSystem@AddNaturalModAPIGravityToEntity)|Adds natural gravity to an entity.|
|[CalculateArtificialGravityInPoint(Vector3D)](VRage.Game.ModAPI.IMyGravityProviderSystem@CalculateArtificialGravityInPoint)|Provides a vector of all artificial gravity at a set of coordinates.|
|[CalculateHighestNaturalGravityMultiplierInPoint(Vector3D)](VRage.Game.ModAPI.IMyGravityProviderSystem@CalculateHighestNaturalGravityMultiplierInPoint)|Provides the highest natural gravity multiplier at a set of coordinates.|
|[CalculateNaturalGravityInPoint(Vector3D, out float)](VRage.Game.ModAPI.IMyGravityProviderSystem@CalculateNaturalGravityInPoint)|Calculates all natural gravity at provided coordinates, returns gravity vector, and outputs gravity multiplier|
|[CalculateNaturalGravityInPoint(Vector3D)](VRage.Game.ModAPI.IMyGravityProviderSystem@CalculateNaturalGravityInPoint)|Provides a vector of all natural gravity at a set of coordinates.|
|[CalculateTotalGravityInPoint(Vector3D)](VRage.Game.ModAPI.IMyGravityProviderSystem@CalculateTotalGravityInPoint)|Provides a vector of all natural and artificial gravity at a sec of coordinates.|
|[DoesEntityHaveGravityProvider(IMyEntity)](VRage.Game.ModAPI.IMyGravityProviderSystem@DoesEntityHaveGravityProvider)|Determines if a provided entity is generating gravity (artificial or natural).|
|[DoesTrajectoryIntersectNaturalGravity(Vector3D, Vector3D, double)](VRage.Game.ModAPI.IMyGravityProviderSystem@DoesTrajectoryIntersectNaturalGravity)|Checks if the specified trajectory intersects any natural gravity wells.|
|[GetStrongestNaturalGravityWell(Vector3D, out IMyNaturalGravityComponent)](VRage.Game.ModAPI.IMyGravityProviderSystem@GetStrongestNaturalGravityWell)|Determines the strongest natural gravity source at a given set of coordinates.|
|[IsPositionInNaturalGravity(Vector3D, double)](VRage.Game.ModAPI.IMyGravityProviderSystem@IsPositionInNaturalGravity)|This quickly checks if a given position is in any natural gravity.|
|[RemoveNaturalGravity(IMyNaturalGravityComponent)](VRage.Game.ModAPI.IMyGravityProviderSystem@RemoveNaturalGravity)|Removes the natural gravity component provided.|
|[RemoveNaturalGravityFromEntity(IMyEntity)](VRage.Game.ModAPI.IMyGravityProviderSystem@RemoveNaturalGravityFromEntity)|Removes the natural gravity from a provided entity.|

