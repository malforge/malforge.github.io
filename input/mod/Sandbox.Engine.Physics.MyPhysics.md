**Assembly:** Sandbox.Game.dll

```csharp
public class MyPhysics: MySessionComponentBase, IMyUserInputComponent
```

## Fields

|Member|Description|
|---|---|
|[static Clusters](Sandbox.Engine.Physics.MyPhysics@Clusters)||
|[static DebugDrawClustersEnable](Sandbox.Engine.Physics.MyPhysics@DebugDrawClustersEnable)||
|[static DebugDrawClustersMatrix](Sandbox.Engine.Physics.MyPhysics@DebugDrawClustersMatrix)||
|[static SyncVDBCamera](Sandbox.Engine.Physics.MyPhysics@SyncVDBCamera)||
|[static ThreadId](Sandbox.Engine.Physics.MyPhysics@ThreadId)||
|[static WorkPriority](Sandbox.Engine.Physics.MyPhysics@WorkPriority)||
|[StopEnable](Sandbox.Engine.Physics.MyPhysics@StopEnable)||
|[ComponentType](VRage.Game.Components.MySessionComponentBase@ComponentType)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[DebugName](VRage.Game.Components.MySessionComponentBase@DebugName)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Priority](VRage.Game.Components.MySessionComponentBase@Priority)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[static InsideSimulation](Sandbox.Engine.Physics.MyPhysics@InsideSimulation)||
|[static QueuedForces](Sandbox.Engine.Physics.MyPhysics@QueuedForces)||
|[static RaycastLock](Sandbox.Engine.Physics.MyPhysics@RaycastLock)||
|[static RestingVelocity](Sandbox.Engine.Physics.MyPhysics@RestingVelocity)||
|[static SimulationRatio](Sandbox.Engine.Physics.MyPhysics@SimulationRatio)|Simulation ratio, when physics cannot keep up, this is smaller than 1|
|[static SingleWorld](Sandbox.Engine.Physics.MyPhysics@SingleWorld)||
|[static StepsLastSecond](Sandbox.Engine.Physics.MyPhysics@StepsLastSecond)|Number of physics steps done in last second|
|[Definition](VRage.Game.Components.MySessionComponentBase@Definition)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Dependencies](VRage.Game.Components.MySessionComponentBase@Dependencies)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Initialized](VRage.Game.Components.MySessionComponentBase@Initialized)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[IsRequiredByGame](VRage.Game.Components.MySessionComponentBase@IsRequiredByGame)|Indicates whether a session component should be used in current configuration. Example: MyDestructionData component returns true only when game uses Havok Destruction<br /><br />_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[IsServerOnly](VRage.Game.Components.MySessionComponentBase@IsServerOnly)|Is server only is used for client request of the world. if the component is server only, it's not sent to the client on world request.<br /><br />_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Loaded](VRage.Game.Components.MySessionComponentBase@Loaded)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[ModContext](VRage.Game.Components.MySessionComponentBase@ModContext)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[ObjectBuilderType](VRage.Game.Components.MySessionComponentBase@ObjectBuilderType)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Session](VRage.Game.Components.MySessionComponentBase@Session)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateOnPause](VRage.Game.Components.MySessionComponentBase@UpdateOnPause)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateOrder](VRage.Game.Components.MySessionComponentBase@UpdateOrder)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyPhysics()](Sandbox.Engine.Physics.MyPhysics@.ctor)||
|[MySessionComponentBase()](VRage.Game.Components.MySessionComponentBase@.ctor)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[static ActivateInBox(ref BoundingBoxD)](Sandbox.Engine.Physics.MyPhysics@ActivateInBox)||
|[static AssertThread()](Sandbox.Engine.Physics.MyPhysics@AssertThread)||
|[static CastChainedRaycastsParallel(int, Func<int, bool>, Action<int>, int, Func<bool>)](Sandbox.Engine.Physics.MyPhysics@CastChainedRaycastsParallel)||
|[static CastLongRay(Vector3D, Vector3D, bool)](Sandbox.Engine.Physics.MyPhysics@CastLongRay)|Finds closest or any object on the path of the ray from->to. Uses Storage for voxels for faster search but only good for long rays (more or less more than 50m). Use it only in such cases.|
|[static CastRay(Vector3D, Vector3D, List<HitInfo>, int)](Sandbox.Engine.Physics.MyPhysics@CastRay)||
|[static CastRay(Vector3D, Vector3D, int)](Sandbox.Engine.Physics.MyPhysics@CastRay)||
|[static CastRay(Vector3D, Vector3D, out HitInfo, uint, bool)](Sandbox.Engine.Physics.MyPhysics@CastRay)||
|[static CastRay_AllHits(Vector3D, Vector3D)](Sandbox.Engine.Physics.MyPhysics@CastRay_AllHits)||
|[static CastRayParallel(ref Vector3D, ref Vector3D, int, Action<HitInfo?>)](Sandbox.Engine.Physics.MyPhysics@CastRayParallel)||
|[static CastRayParallel(ref Vector3D, ref Vector3D, List<HitInfo>, int, Action<List<HitInfo>>)](Sandbox.Engine.Physics.MyPhysics@CastRayParallel)||
|[static CastRayWorld(MyClusterQueryResult, Vector3D, Vector3D, List<HitInfo>, int)](Sandbox.Engine.Physics.MyPhysics@CastRayWorld)||
|[static CastShape(Vector3D, HkShape, ref MatrixD, int, float)](Sandbox.Engine.Physics.MyPhysics@CastShape)||
|[static CastShapeInAllWorlds(Vector3D, HkShape, ref MatrixD, int, float)](Sandbox.Engine.Physics.MyPhysics@CastShapeInAllWorlds)||
|[static CastShapeReturnContact(Vector3D, HkShape, ref MatrixD, int, float, out Vector3D)](Sandbox.Engine.Physics.MyPhysics@CastShapeReturnContact)||
|[static CastShapeReturnContactBodyData(Vector3D, HkShape, ref MatrixD, uint, float, bool)](Sandbox.Engine.Physics.MyPhysics@CastShapeReturnContactBodyData)||
|[static CastShapeReturnContactBodyDatas(Vector3D, HkShape, ref MatrixD, uint, float, List<HitInfo>, bool)](Sandbox.Engine.Physics.MyPhysics@CastShapeReturnContactBodyDatas)||
|[static CastShapeReturnContactData(Vector3D, HkShape, ref MatrixD, uint, float, bool)](Sandbox.Engine.Physics.MyPhysics@CastShapeReturnContactData)||
|[static CastShapeReturnPoint(Vector3D, HkShape, ref MatrixD, int, float)](Sandbox.Engine.Physics.MyPhysics@CastShapeReturnPoint)||
|[static CheckThread()](Sandbox.Engine.Physics.MyPhysics@CheckThread)||
|[static CommitSchedulingSettingToServer()](Sandbox.Engine.Physics.MyPhysics@CommitSchedulingSettingToServer)||
|[static ControlVDBRecording(string)](Sandbox.Engine.Physics.MyPhysics@ControlVDBRecording)||
|[static CreateHkWorld(float)](Sandbox.Engine.Physics.MyPhysics@CreateHkWorld)||
|[static DebugDrawClusters()](Sandbox.Engine.Physics.MyPhysics@DebugDrawClusters)||
|[static DeserializeClusters(List<BoundingBoxD>)](Sandbox.Engine.Physics.MyPhysics@DeserializeClusters)||
|[static EnsurePhysicsSpace(BoundingBoxD)](Sandbox.Engine.Physics.MyPhysics@EnsurePhysicsSpace)|Ensure aabb is inside only one subspace. If no, reorder.|
|[static GetAll(List<MyClusterQueryResult>)](Sandbox.Engine.Physics.MyPhysics@GetAll)||
|[static GetClusterList()](Sandbox.Engine.Physics.MyPhysics@GetClusterList)||
|[static GetCollisionLayer(string)](Sandbox.Engine.Physics.MyPhysics@GetCollisionLayer)||
|[static GetHkWorld(ref Vector3D)](Sandbox.Engine.Physics.MyPhysics@GetHkWorld)||
|[static GetObjectOffset(ulong)](Sandbox.Engine.Physics.MyPhysics@GetObjectOffset)|Return offset of objects subspace center.|
|[static GetPenetrationsBox(ref Vector3, ref Vector3D, ref Quaternion, List<HkBodyCollision>, int)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsBox)||
|[static GetPenetrationsBoxParallel(ref Vector3, ref Vector3D, ref Quaternion, List<HkBodyCollision>, int, Action<List<HkBodyCollision>>)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsBoxParallel)||
|[static GetPenetrationsShape(HkShape, ref Vector3D, ref Quaternion, List<HkBodyCollision>, int)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsShape)||
|[static GetPenetrationsShape(HkShape, ref Vector3D, ref Quaternion, HashSet<HkRigidBody>, int)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsShape)||
|[static GetPenetrationsShapeParallel(HkShape, ref Vector3D, ref Quaternion, HashSet<HkRigidBody>, int, Action<HashSet<HkRigidBody>>)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsShapeParallel)||
|[static GetPenetrationsShapeShape(HkShape, ref Vector3, ref Quaternion, HkShape, ref Vector3, ref Quaternion)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsShapeShape)||
|[static GetPenetrationsShapeShape(HkShape, ref Vector3, ref Quaternion, HkShape, ref Vector3, ref Quaternion, List<HkShapeCollision>)](Sandbox.Engine.Physics.MyPhysics@GetPenetrationsShapeShape)||
|[static IsPenetratingShapeShape(HkShape, ref Vector3D, ref Quaternion, HkShape, ref Vector3D, ref Quaternion)](Sandbox.Engine.Physics.MyPhysics@IsPenetratingShapeShape)||
|[static IsPenetratingShapeShape(HkShape, ref Matrix, HkShape, ref Matrix)](Sandbox.Engine.Physics.MyPhysics@IsPenetratingShapeShape)||
|[static IsPenetratingShapeShapeInsideOfHavok(HkShape, ref Vector3D, ref Quaternion, HkShape, ref Vector3D, ref Quaternion)](Sandbox.Engine.Physics.MyPhysics@IsPenetratingShapeShapeInsideOfHavok)||
|[static MoveObject(ulong, BoundingBoxD, Vector3)](Sandbox.Engine.Physics.MyPhysics@MoveObject)|Change position of object in world. Move object between subspaces if necessary.|
|[static ProfileHkCall(Action)](Sandbox.Engine.Physics.MyPhysics@ProfileHkCall)||
|[static RefreshCollisionFilter(MyPhysicsBody)](Sandbox.Engine.Physics.MyPhysics@RefreshCollisionFilter)||
|[static RemoveObject(ulong)](Sandbox.Engine.Physics.MyPhysics@RemoveObject)|Remove object from world, remove also subspace if empty.|
|[static Schedule(Action, string)](Sandbox.Engine.Physics.MyPhysics@Schedule)||
|[static SerializeClusters(List<BoundingBoxD>)](Sandbox.Engine.Physics.MyPhysics@SerializeClusters)||
|[static SetScheduling(bool, bool)](Sandbox.Engine.Physics.MyPhysics@SetScheduling)||
|[static TryAddEntity(IMyEntity, MyPhysicsBody, bool)](Sandbox.Engine.Physics.MyPhysics@TryAddEntity)|Attempts to add the entity to the cluster Creates new cluster if allowed (!SingleCluster.HasValue) and needed (entity is outside of existing clusters). If not allowed, marks entity as left the world.|
|[GetEntityReplicableExistsById(long)](Sandbox.Engine.Physics.MyPhysics@GetEntityReplicableExistsById)||
|[InformReplicationEnded(MyEntity)](Sandbox.Engine.Physics.MyPhysics@InformReplicationEnded)||
|[InformReplicationStarted(MyEntity)](Sandbox.Engine.Physics.MyPhysics@InformReplicationStarted)||
|[LoadData()](Sandbox.Engine.Physics.MyPhysics@LoadData)||
|[Simulate()](Sandbox.Engine.Physics.MyPhysics@Simulate)||
|[AfterLoadData()](VRage.Game.Components.MySessionComponentBase@AfterLoadData)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[BeforeStart()](VRage.Game.Components.MySessionComponentBase@BeforeStart)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Draw()](VRage.Game.Components.MySessionComponentBase@Draw)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[GetObjectBuilder()](VRage.Game.Components.MySessionComponentBase@GetObjectBuilder)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[HandleInput()](VRage.Game.Components.Interfaces.IMyUserInputComponent@HandleInput)|_Inherited from [IMyUserInputComponent](VRage.Game.Components.Interfaces.IMyUserInputComponent)_|
|[HandleInput()](VRage.Game.Components.MySessionComponentBase@HandleInput)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Init(MyObjectBuilder_SessionComponent)](VRage.Game.Components.MySessionComponentBase@Init)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[InitFromDefinition(MySessionComponentDefinition)](VRage.Game.Components.MySessionComponentBase@InitFromDefinition)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[LoadData()](VRage.Game.Components.MySessionComponentBase@LoadData)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[SaveData()](VRage.Game.Components.MySessionComponentBase@SaveData)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[SetUpdateOrder(MyUpdateOrder)](VRage.Game.Components.MySessionComponentBase@SetUpdateOrder)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Simulate()](VRage.Game.Components.MySessionComponentBase@Simulate)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[ToString()](VRage.Game.Components.MySessionComponentBase@ToString)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UnloadDataConditional()](VRage.Game.Components.MySessionComponentBase@UnloadDataConditional)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateAfterSimulation()](VRage.Game.Components.MySessionComponentBase@UpdateAfterSimulation)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateBeforeSimulation()](VRage.Game.Components.MySessionComponentBase@UpdateBeforeSimulation)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdatedBeforeInit()](VRage.Game.Components.MySessionComponentBase@UpdatedBeforeInit)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdatingStopped()](VRage.Game.Components.MySessionComponentBase@UpdatingStopped)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

**Inheritance:**   [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)

**Implements:**  
* [IMyUserInputComponent](VRage.Game.Components.Interfaces.IMyUserInputComponent)

