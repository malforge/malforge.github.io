**Assembly:** VRage.Game.dll

```csharp
public interface IMyPhysics
```

Mod API interface giving you access to physics

## Properties

|Member|Description|
|---|---|
|[ServerSimulationRatio](VRage.Game.ModAPI.IMyPhysics@ServerSimulationRatio)|The server's simulation ratio. When physics cannot keep up server side this is smaller than 1.|
|[SimulationRatio](VRage.Game.ModAPI.IMyPhysics@SimulationRatio)|Simulation ratio, when physics cannot keep up, this is smaller than 1|
|[StepsLastSecond](VRage.Game.ModAPI.IMyPhysics@StepsLastSecond)|Number of physics steps done in last second|

## Methods

|Member|Description|
|---|---|
|[CalculateArtificialGravityAt(Vector3D, float)](VRage.Game.ModAPI.IMyPhysics@CalculateArtificialGravityAt)|Returns current artificial gravity at world position.|
|[CalculateNaturalGravityAt(Vector3D, out float)](VRage.Game.ModAPI.IMyPhysics@CalculateNaturalGravityAt)|Returns current natural gravity at world position.|
|[CastLongRay(Vector3D, Vector3D, out IHitInfo, bool)](VRage.Game.ModAPI.IMyPhysics@CastLongRay)|Finds closest or any object on the path of the ray from->to. Uses Storage for voxels for faster search but only good for long rays (more or less more than 50m). Use it only in such cases.|
|[CastRay(Vector3D, Vector3D, List<IHitInfo>, int)](VRage.Game.ModAPI.IMyPhysics@CastRay)|Cast a ray and returns all matching entities. Must not be called from parallel thread!!!|
|[CastRay(Vector3D, Vector3D, out IHitInfo, int)](VRage.Game.ModAPI.IMyPhysics@CastRay)|Cast a ray and return first entity. Must not be called from parallel thread!!!|
|[CastRay(Vector3D, Vector3D, out IHitInfo, uint, bool)](VRage.Game.ModAPI.IMyPhysics@CastRay)|Cast a ray and return first entity. Must not be called from parallel thread!!!|
|[CastRayParallel(ref Vector3D, ref Vector3D, int, Action<IHitInfo>)](VRage.Game.ModAPI.IMyPhysics@CastRayParallel)|Cast a ray and return first entity. May be called from parallel thread.|
|[CastRayParallel(ref Vector3D, ref Vector3D, List<IHitInfo>, int, Action<List<IHitInfo>>)](VRage.Game.ModAPI.IMyPhysics@CastRayParallel)||
|[CreateBoxPhysics(PhysicsSettings, Vector3, float)](VRage.Game.ModAPI.IMyPhysics@CreateBoxPhysics)|Creates physical body when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is null, or physics detector, when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is not null. Created physics has a box collision|
|[CreateCapsulePhysics(PhysicsSettings, Vector3, Vector3, float)](VRage.Game.ModAPI.IMyPhysics@CreateCapsulePhysics)|Creates physical body when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is null, or physics detector, when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is not null. Created physics has a capsule collision|
|[CreateMassCombined(ICollection<ModAPIMassElement>)](VRage.Game.ModAPI.IMyPhysics@CreateMassCombined)|Calculates mass combined from other several masses|
|[CreateMassForBox(Vector3, float)](VRage.Game.ModAPI.IMyPhysics@CreateMassForBox)|Creates mass for cube|
|[CreateMassForCapsule(Vector3, Vector3, float, float)](VRage.Game.ModAPI.IMyPhysics@CreateMassForCapsule)|Creates mass for capsule|
|[CreateMassForCylinder(Vector3, Vector3, float, float)](VRage.Game.ModAPI.IMyPhysics@CreateMassForCylinder)|Creates mass for cylinder|
|[CreateMassForSphere(float, float)](VRage.Game.ModAPI.IMyPhysics@CreateMassForSphere)|Creates mass for sphere|
|[CreateModelPhysics(PhysicsSettings)](VRage.Game.ModAPI.IMyPhysics@CreateModelPhysics)|Creates physical body when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is null, or physics detector, when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is not null. Created physics has a collision model, taken from entity model|
|[CreateSettingsForDetector(IMyEntity, Action<IMyEntity, bool>, MatrixD, Vector3, RigidBodyFlag, ushort, bool)](VRage.Game.ModAPI.IMyPhysics@CreateSettingsForDetector)|Used to create physical detectors. They don't have physical collisions, instead they provide trigger callbacks when Entities collide with their shape|
|[CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, float, float, ushort, RigidBodyFlag, bool, ModAPIMass?)](VRage.Game.ModAPI.IMyPhysics@CreateSettingsForPhysics)|Used for create physics with collisions|
|[CreateSpherePhysics(PhysicsSettings, float)](VRage.Game.ModAPI.IMyPhysics@CreateSpherePhysics)|Creates physical body when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is null, or physics detector, when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is not null. Created physics has a sphere collision|
|[EnsurePhysicsSpace(BoundingBoxD)](VRage.Game.ModAPI.IMyPhysics@EnsurePhysicsSpace)|Ensure aabb is inside only one subspace. If no, reorder. Must not be called from parallel thread!!!|
|[GetCollisionLayer(string)](VRage.Game.ModAPI.IMyPhysics@GetCollisionLayer)|Given a string, gets the numeric value for the collision layer. Default: 0. TargetDummyLayer = 6 BlockPlacementTestCollisionLayer = 7 MissileLayer = 8 NoVoxelCollisionLayer = 9 LightFloatingObjectCollisionLayer = 10 VoxelLod1CollisionLayer = 11 NotCollideWithStaticLayer = 12 StaticCollisionLayer = 13 CollideWithStaticLayer = 14 DefaultCollisionLayer = 15 DynamicDoubledCollisionLayer = 16 KinematicDoubledCollisionLayer = 17 CharacterCollisionLayer = 18 NoCollisionLayer = 19 DebrisCollisionLayer = 20 GravityPhantomLayer = 21 CharacterNetworkCollisionLayer = 22 FloatingObjectCollisionLayer = 23 ObjectDetectionCollisionLayer = 24 VirtualMassLayer = 25 CollectorCollisionLayer = 26 AmmoLayer = 27 VoxelCollisionLayer = 28 ExplosionRaycastLayer = 29 CollisionLayerWithoutCharacter = 30 RagdollCollisionLayer = 31|
|[GetWeaponLeadPrediction(IMyEntity, IMyEntity, MyDefinitionId)](VRage.Game.ModAPI.IMyPhysics@GetWeaponLeadPrediction)|Gets the predicted target coordinates of an entity for weapon leading. Will return Vector3D.Zero if the entity is not valid. If the predicted intercept position cannot be calculated because of missing physics or ammo definitions, then it will return the entity position instead.|

