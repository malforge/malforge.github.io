**Assembly:** VRage.Game.dll

```csharp
public interface IHitInfo
```

## Properties

|Member|Description|
|---|---|
|[Fraction](VRage.Game.ModAPI.IHitInfo@Fraction)|How much of the ray cast distance was traveled before hitting something. Use this value to multiply your initial distance to get the distance to hit position in a cheaper way.|
|[HitEntity](VRage.Game.ModAPI.IHitInfo@HitEntity)|The entity that was hit.|
|[Normal](VRage.Game.ModAPI.IHitInfo@Normal)|The direction vector of the hit surface.|
|[Position](VRage.Game.ModAPI.IHitInfo@Position)|The position where the raycast hit.|

**Inheritors:**  
* [HitInfo](Sandbox.Engine.Physics.MyPhysics+HitInfo)

