**Assembly:** VRage.Game.dll

```csharp
public abstract class MyPhysicsComponentBase: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[ContactPointDelay](VRage.Game.Components.MyPhysicsComponentBase@ContactPointDelay)|Must be set before creating rigid body|
|[EnabledChanged](VRage.Game.Components.MyPhysicsComponentBase@EnabledChanged)||
|[Flags](VRage.Game.Components.MyPhysicsComponentBase@Flags)||
|[IsPhantom](VRage.Game.Components.MyPhysicsComponentBase@IsPhantom)|Use something from Havok to detect this|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBodyActiveStateChanged](VRage.Game.Components.MyPhysicsComponentBase@OnBodyActiveStateChanged)|OnBodyActiveStateChanged event - arg1 - Sender, arg2 - is active|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AngularAcceleration](VRage.Game.Components.MyPhysicsComponentBase@AngularAcceleration)||
|[AngularDamping](VRage.Game.Components.MyPhysicsComponentBase@AngularDamping)|Gets or sets the angular damping.|
|[AngularVelocity](VRage.Game.Components.MyPhysicsComponentBase@AngularVelocity)||
|[AngularVelocityLocal](VRage.Game.Components.MyPhysicsComponentBase@AngularVelocityLocal)||
|[CanUpdateAccelerations](VRage.Game.Components.MyPhysicsComponentBase@CanUpdateAccelerations)||
|[Center](VRage.Game.Components.MyPhysicsComponentBase@Center)||
|[CenterOfMassLocal](VRage.Game.Components.MyPhysicsComponentBase@CenterOfMassLocal)||
|[CenterOfMassWorld](VRage.Game.Components.MyPhysicsComponentBase@CenterOfMassWorld)||
|[ComponentTypeDebugString](VRage.Game.Components.MyPhysicsComponentBase@ComponentTypeDebugString)||
|[Definition](VRage.Game.Components.MyPhysicsComponentBase@Definition)||
|[Enabled](VRage.Game.Components.MyPhysicsComponentBase@Enabled)|Gets or sets a value indicating whether this is enabled.|
|[Entity](VRage.Game.Components.MyPhysicsComponentBase@Entity)||
|[Friction](VRage.Game.Components.MyPhysicsComponentBase@Friction)||
|[Gravity](VRage.Game.Components.MyPhysicsComponentBase@Gravity)||
|[HasRigidBody](VRage.Game.Components.MyPhysicsComponentBase@HasRigidBody)||
|[IsActive](VRage.Game.Components.MyPhysicsComponentBase@IsActive)||
|[IsInWorld](VRage.Game.Components.MyPhysicsComponentBase@IsInWorld)||
|[IsKinematic](VRage.Game.Components.MyPhysicsComponentBase@IsKinematic)|Gets or sets a value indicating whether this is kinematic.|
|[IsMoving](VRage.Game.Components.MyPhysicsComponentBase@IsMoving)||
|[IsStatic](VRage.Game.Components.MyPhysicsComponentBase@IsStatic)|Gets or sets a value indicating whether this is static.|
|[LinearAcceleration](VRage.Game.Components.MyPhysicsComponentBase@LinearAcceleration)||
|[LinearDamping](VRage.Game.Components.MyPhysicsComponentBase@LinearDamping)|Gets or sets the linear damping.|
|[LinearVelocity](VRage.Game.Components.MyPhysicsComponentBase@LinearVelocity)|Gets or sets the linear velocity.|
|[LinearVelocityLocal](VRage.Game.Components.MyPhysicsComponentBase@LinearVelocityLocal)||
|[LinearVelocityUnsafe](VRage.Game.Components.MyPhysicsComponentBase@LinearVelocityUnsafe)||
|[Mass](VRage.Game.Components.MyPhysicsComponentBase@Mass)|Gets or sets the mass.|
|[MaterialType](VRage.Game.Components.MyPhysicsComponentBase@MaterialType)|Gets or sets the type of the material.|
|[PlayCollisionCueEnabled](VRage.Game.Components.MyPhysicsComponentBase@PlayCollisionCueEnabled)|Gets or sets a value indicating whether [play collision cue enabled].|
|[ReportAllContacts](VRage.Game.Components.MyPhysicsComponentBase@ReportAllContacts)||
|[RigidBody](VRage.Game.Components.MyPhysicsComponentBase@RigidBody)|Obtain/set (default) rigid body of this physics object.|
|[RigidBody2](VRage.Game.Components.MyPhysicsComponentBase@RigidBody2)|Obtain/set secondary rigid body of this physics object (not used by default, it is used sometimes on grids for kinematic layer).|
|[ShapeChangeInProgress](VRage.Game.Components.MyPhysicsComponentBase@ShapeChangeInProgress)||
|[Speed](VRage.Game.Components.MyPhysicsComponentBase@Speed)|Gets or sets the speed.|
|[SupportNormal](VRage.Game.Components.MyPhysicsComponentBase@SupportNormal)||
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[Activate()](VRage.Game.Components.MyPhysicsComponentBase@Activate)|Activates this rigid body in physics.|
|[AddForce(MyPhysicsForceType, Vector3?, Vector3D?, Vector3?, float?, bool, bool)](VRage.Game.Components.MyPhysicsComponentBase@AddForce)|Applies external force to the physics object.|
|[ApplyImpulse(Vector3, Vector3D)](VRage.Game.Components.MyPhysicsComponentBase@ApplyImpulse)|Applies the impulse.|
|[Clear()](VRage.Game.Components.MyPhysicsComponentBase@Clear)|Clear all dynamic values of physics object.|
|[ClearSpeed()](VRage.Game.Components.MyPhysicsComponentBase@ClearSpeed)|Clears the speeds.|
|[Close()](VRage.Game.Components.MyPhysicsComponentBase@Close)||
|[ClusterToWorld(Vector3)](VRage.Game.Components.MyPhysicsComponentBase@ClusterToWorld)|Converts local cluster position to global space.|
|[CreateCharacterCollision(Vector3, float, float, float, float, float, float, MatrixD, float, ushort, bool, float, float, float, bool, float?)](VRage.Game.Components.MyPhysicsComponentBase@CreateCharacterCollision)||
|[Deactivate()](VRage.Game.Components.MyPhysicsComponentBase@Deactivate)|Deactivates this rigid body in physics.|
|[DebugDraw()](VRage.Game.Components.MyPhysicsComponentBase@DebugDraw)|Debug draw of this physics object.|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyPhysicsComponentBase@Deserialize)||
|[ForceActivate()](VRage.Game.Components.MyPhysicsComponentBase@ForceActivate)||
|[GetMaterialAt(Vector3D)](VRage.Game.Components.MyPhysicsComponentBase@GetMaterialAt)||
|[GetVelocityAtPoint(Vector3D)](VRage.Game.Components.MyPhysicsComponentBase@GetVelocityAtPoint)||
|[GetVelocityAtPointLocal(ref Vector3D, out Vector3)](VRage.Game.Components.MyPhysicsComponentBase@GetVelocityAtPointLocal)||
|[GetWorldMatrix()](VRage.Game.Components.MyPhysicsComponentBase@GetWorldMatrix)||
|[GetWorldMatrix(out MatrixD)](VRage.Game.Components.MyPhysicsComponentBase@GetWorldMatrix)||
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyPhysicsComponentBase@Init)||
|[IsSerialized()](VRage.Game.Components.MyPhysicsComponentBase@IsSerialized)||
|[OnAddedToContainer()](VRage.Game.Components.MyPhysicsComponentBase@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyPhysicsComponentBase@OnBeforeRemovedFromContainer)||
|[OnWorldPositionChanged(object)](VRage.Game.Components.MyPhysicsComponentBase@OnWorldPositionChanged)|Called when [world position changed].|
|[Serialize(bool)](VRage.Game.Components.MyPhysicsComponentBase@Serialize)||
|[SetSpeeds(Vector3, Vector3)](VRage.Game.Components.MyPhysicsComponentBase@SetSpeeds)|Set the current linear and angular velocities of this physics body.|
|[UpdateAccelerations()](VRage.Game.Components.MyPhysicsComponentBase@UpdateAccelerations)||
|[UpdateFromSystem()](VRage.Game.Components.MyPhysicsComponentBase@UpdateFromSystem)||
|[WorldToCluster(Vector3D)](VRage.Game.Components.MyPhysicsComponentBase@WorldToCluster)|Converts global space position to local cluster space.|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

