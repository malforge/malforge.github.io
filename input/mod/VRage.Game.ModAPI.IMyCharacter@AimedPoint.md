## Summary

```csharp
public Vector3D AimedPoint { get; set; }
```

Gets or, for non-player controlled characters, sets the aimed point direction.

## Returns

[Vector3D](VRageMath.Vector3D)

## Remarks

For characters, which are not controlled by player, this will set the aimed point, otherwise the aimed point is determined from camera matrix

