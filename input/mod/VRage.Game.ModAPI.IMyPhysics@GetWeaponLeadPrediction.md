## Summary

```csharp
public Vector3D GetWeaponLeadPrediction(IMyEntity shooter, IMyEntity target, MyDefinitionId ammoDefinitionId)
```

Gets the predicted target coordinates of an entity for weapon leading. Will return Vector3D.Zero if the entity is not valid. If the predicted intercept position cannot be calculated because of missing physics or ammo definitions, then it will return the entity position instead.

## Returns

[Vector3D](VRageMath.Vector3D)

Vector3D world coordinates of where a fired shot from the weapon should intercept the provided entity target.

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) shooter
* [IMyEntity](VRage.ModAPI.IMyEntity) target
* [MyDefinitionId](VRage.Game.MyDefinitionId) ammoDefinitionId
