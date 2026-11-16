## Summary

```csharp
public Vector3 PointShadowResolutionPadding
```

Padding, kept because it is part of the constant buffer's layout that DX11 and DX12 share. It carried the per-tier point-shadow resolutions until each cube got a size of its own, which travels in the b1 info row.

## Returns

[Vector3](VRageMath.Vector3)

