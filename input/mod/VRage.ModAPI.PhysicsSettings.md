**Assembly:** VRage.Game.dll

```csharp
public struct PhysicsSettings
```

Implements Physics Settings

## Fields

|Member|Description|
|---|---|
|[AngularDamping](VRage.ModAPI.PhysicsSettings@AngularDamping)|Gets or Sets the Angular Damping. SE default value is 0.1|
|[CollisionLayer](VRage.ModAPI.PhysicsSettings@CollisionLayer)|Collision layer. Makes your entity react on collisions with entities that having certain layers TargetDummyLayer = 6 BlockPlacementTestCollisionLayer = 7 MissileLayer = 8 NoVoxelCollisionLayer = 9 LightFloatingObjectCollisionLayer = 10 VoxelLod1CollisionLayer = 11 NotCollideWithStaticLayer = 12 StaticCollisionLayer = 13 CollideWithStaticLayer = 14 DefaultCollisionLayer = 15 DynamicDoubledCollisionLayer = 16 KinematicDoubledCollisionLayer = 17 CharacterCollisionLayer = 18 NoCollisionLayer = 19 DebrisCollisionLayer = 20 GravityPhantomLayer = 21 CharacterNetworkCollisionLayer = 22 FloatingObjectCollisionLayer = 23 ObjectDetectionCollisionLayer = 24 VirtualMassLayer = 25 CollectorCollisionLayer = 26 AmmoLayer = 27 VoxelCollisionLayer = 28 ExplosionRaycastLayer = 29 CollisionLayerWithoutCharacter = 30 RagdollCollisionLayer = 31|
|[DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback)|If it is not null, then it would be call this callback each time entity Enters/Leaves it's collision. Also removes physical collision (Now all entities can go through it) CollisionCallback is called from parallel thread, and called once per HkBody. Grids can have more than 100 bodies. Try find best collision layer, to filter unneeded collisions and improve performance If you trying detect grids:```csharp<br />protected MyConcurrentHashSet<long> m_containedEntities = new MyConcurrentHashSet<long>();<br />var topEntity = entity.GetTopMostParent() as MyEntity;<br />if (m_containedEntities.Add(topEntity.EntityId))<br />{<br />    MyAPIGateway.Utilities.InvokeOnGameThread(() =><br />    {<br />        //Called once in main thread<br />    });<br />}<br /><br />```|
|[Entity](VRage.ModAPI.PhysicsSettings@Entity)|For modders: You can create your own entities with this code.```csharp<br />var entity = new MyEntity();<br />entity.WorldMatrix = MatrixD.Identity;<br />entity.Init(new StringBuilder("Name"), "Models\\Cubes\\Large\\GeneratorLarge.mwm", null, null, "Models\\Cubes\\Large\\GeneratorLarge.mwm");<br />MyAPIGateway.Entities.AddEntity(entity);<br /><br />```|
|[IsPhantom](VRage.ModAPI.PhysicsSettings@IsPhantom)|Is mainly used, to detect if block can be placed at this position|
|[LinearDamping](VRage.ModAPI.PhysicsSettings@LinearDamping)|Gets or Sets the Linear Damping in meters per tick|
|[LocalCenter](VRage.ModAPI.PhysicsSettings@LocalCenter)|Gets or Sets the Center of physical shape|
|[Mass](VRage.ModAPI.PhysicsSettings@Mass)|Gets or Sets the mass of object|
|[MaterialType](VRage.ModAPI.PhysicsSettings@MaterialType)|Gets or Sets From what material object is. Example: Rock,Metal,Ammo,Character,Wood,Thruster_large,Thruster_small,Missile|
|[RigidBodyFlags](VRage.ModAPI.PhysicsSettings@RigidBodyFlags)|Gets or Sets the Flags, defining behavioral features|
|[WorldMatrix](VRage.ModAPI.PhysicsSettings@WorldMatrix)|Gets or Sets the World matrix of physical shape|

