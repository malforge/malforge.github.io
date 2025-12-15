## Summary

```csharp
public Vector3D Coords { get; set; }
```

Gets or sets GPS coordinates

## Returns

[Vector3D](VRageMath.Vector3D)

## Remarks

Set method doesn't synchronize data over network. Use [ModifyGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@ModifyGps) , to update data

