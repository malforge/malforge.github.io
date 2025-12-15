**Assembly:** Sandbox.Game.dll

```csharp
public struct HitInfo: IHitInfo
```

## Fields

|Member|Description|
|---|---|
|[HkHitInfo](Sandbox.Engine.Physics.MyPhysics+HitInfo@HkHitInfo)||
|[Position](Sandbox.Engine.Physics.MyPhysics+HitInfo@Position)||

## Properties

|Member|Description|
|---|---|
|[Fraction](VRage.Game.ModAPI.IHitInfo@Fraction)|How much of the ray cast distance was traveled before hitting something. Use this value to multiply your initial distance to get the distance to hit position in a cheaper way.<br /><br />_Inherited from [IHitInfo](VRage.Game.ModAPI.IHitInfo)_|
|[HitEntity](VRage.Game.ModAPI.IHitInfo@HitEntity)|The entity that was hit.<br /><br />_Inherited from [IHitInfo](VRage.Game.ModAPI.IHitInfo)_|
|[Normal](VRage.Game.ModAPI.IHitInfo@Normal)|The direction vector of the hit surface.<br /><br />_Inherited from [IHitInfo](VRage.Game.ModAPI.IHitInfo)_|
|[Position](VRage.Game.ModAPI.IHitInfo@Position)|The position where the raycast hit.<br /><br />_Inherited from [IHitInfo](VRage.Game.ModAPI.IHitInfo)_|

## Constructors

|Member|Description|
|---|---|
|[HitInfo(HkHitInfo, Vector3D)](Sandbox.Engine.Physics.MyPhysics+HitInfo@.ctor)||

## Methods

|Member|Description|
|---|---|
|[ToString()](Sandbox.Engine.Physics.MyPhysics+HitInfo@ToString)||

**Implements:**  
* [IHitInfo](VRage.Game.ModAPI.IHitInfo)

