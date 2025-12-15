**Assembly:** VRage.Game.dll

```csharp
public enum MyItemPositioningEnum
```

Enumeration defining where to get the weapon transform from. This does not include behavior of arms (anim/ik), which is driven separately by variables SimulateLeftHand and SimulateRightHand.

## Fields

|Member|Description|
|---|---|
|TransformFromAnim|Weapon is placed according to animation.|
|TransformFromData|Weapon is placed according to sbc data file.|

