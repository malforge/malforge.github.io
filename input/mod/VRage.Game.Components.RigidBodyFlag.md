**Assembly:** VRage.Game.dll

```csharp
public enum RigidBodyFlag
```

Physical shape settings

## Fields

|Member|Description|
|---|---|
|RBF_BULLET|Used for fast moving objects Changing: MotionType = HkMotionType.Dynamic; QualityType = HkCollidableQualityType.Bullet;|
|RBF_DEBRIS|Used for low quality physics Changing: MotionType = HkMotionType.Dynamic; QualityType = HkCollidableQualityType.Debris; SolverDeactivation = HkSolverDeactivation.Max;|
|RBF_DEFAULT|Default flag|
|RBF_DISABLE_COLLISION_RESPONSE|Rigid body has no collision response. Entities marked with this flag would not update position after Havok physics update. However you still can get position from Havok with code `Physics.GetWorldMatrix` Changing: MotionType = HkMotionType.Fixed; QualityType = HkCollidableQualityType.Fixed;|
|RBF_DOUBLED_KINEMATIC|Used for moving objects with high quality of simulation Changing: MotionType = HkMotionType.Dynamic; QualityType = HkCollidableQualityType.Moving;|
|RBF_KEYFRAMED_REPORTING|Changing: MotionType = HkMotionType.Keyframed; QualityType = HkCollidableQualityType.KeyframedReporting;|
|RBF_KINEMATIC|Rigid body is kinematic (has to be updated (matrix) per frame, velocity etc is then computed..) Changing: MotionType = HkMotionType.Keyframed; QualityType = HkCollidableQualityType.Keyframed;|
|RBF_NO_POSITION_UPDATES|Don't update entity position from havok after simulation|
|RBF_STATIC|Rigid body is static, and colliding with it, won't move it (in Havok and SE worlds) Changing: MotionType = HkMotionType.Fixed; QualityType = HkCollidableQualityType.Fixed;|
|RBF_UNLOCKED_SPEEDS|Making maximum Velocity of entity to x10 of Large/Small ShipMaxLinearVelocity. Used for simulation of very fast moving objects|

