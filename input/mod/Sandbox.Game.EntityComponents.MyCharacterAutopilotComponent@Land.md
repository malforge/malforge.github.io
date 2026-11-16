## Summary

```csharp
public void Land()
```

Descends onto the surface below: descent speed capped by height above terrain, flare to TouchdownSpeed, jetpack off on contact. Zero-g lands along the nearest grid's seat-up axis (mag boots hold on contact); with no grid, no surface, or a touchdown surface steeper than the character's MaxSlope, the order degrades to a brake-and-hold (LastOrderOutcome Degraded). Order intake only — see `MyCharacterAutopilotComponent.FlyTo(Vector3D, MyCharacterAutopilotComponent.MyGravityStrategy, MyEntity)`<sub>prohibited</sub> .

