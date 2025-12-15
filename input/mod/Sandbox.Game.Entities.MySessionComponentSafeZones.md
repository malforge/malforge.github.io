**Assembly:** Sandbox.Game.dll

```csharp
public class MySessionComponentSafeZones: MySessionComponentBase, IMyUserInputComponent
```

## Fields

|Member|Description|
|---|---|
|[static AllowedActions](Sandbox.Game.Entities.MySessionComponentSafeZones@AllowedActions)||
|[ComponentType](VRage.Game.Components.MySessionComponentBase@ComponentType)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[DebugName](VRage.Game.Components.MySessionComponentBase@DebugName)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Priority](VRage.Game.Components.MySessionComponentBase@Priority)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Events

|Member|Description|
|---|---|
|[static OnAddSafeZone](Sandbox.Game.Entities.MySessionComponentSafeZones@OnAddSafeZone)||
|[static OnRemoveSafeZone](Sandbox.Game.Entities.MySessionComponentSafeZones@OnRemoveSafeZone)||
|[static OnSafeZoneUpdated](Sandbox.Game.Entities.MySessionComponentSafeZones@OnSafeZoneUpdated)||

## Properties

|Member|Description|
|---|---|
|[static SafeZones](Sandbox.Game.Entities.MySessionComponentSafeZones@SafeZones)||
|[IsRequiredByGame](Sandbox.Game.Entities.MySessionComponentSafeZones@IsRequiredByGame)||
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
|[MySessionComponentSafeZones()](Sandbox.Game.Entities.MySessionComponentSafeZones@.ctor)||
|[MySessionComponentBase()](VRage.Game.Components.MySessionComponentBase@.ctor)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[static AddSafeZone(MySafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@AddSafeZone)||
|[static CanPerformAction(MySafeZoneAction, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@CanPerformAction)||
|[static CrateSafeZone(MatrixD, MySafeZoneShape, MySafeZoneAccess, Int64[], Int64[], float, bool, bool, Vector3, string, long, string)](Sandbox.Game.Entities.MySessionComponentSafeZones@CrateSafeZone)||
|[static CreateSafeZone_Implementation(Vector3D)](Sandbox.Game.Entities.MySessionComponentSafeZones@CreateSafeZone_Implementation)||
|[static CreateSafeZone_ImplementationPlayer(long, float, bool, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@CreateSafeZone_ImplementationPlayer)||
|[static DeleteSafeZone_Implementation(long)](Sandbox.Game.Entities.MySessionComponentSafeZones@DeleteSafeZone_Implementation)||
|[static DeleteSafeZone_ImplementationPlayer(long, long, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@DeleteSafeZone_ImplementationPlayer)||
|[static GetBelongingSafezones(long, ICollection<MySafeZone>)](Sandbox.Game.Entities.MySessionComponentSafeZones@GetBelongingSafezones)||
|[static GetSafeZonesInAABB(BoundingBoxD, List<MySafeZone>)](Sandbox.Game.Entities.MySessionComponentSafeZones@GetSafeZonesInAABB)||
|[static IsActionAllowed(MyEntity, MySafeZoneAction, long, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowed)|Checks if action is allowed.|
|[static IsActionAllowed(BoundingBoxD, MySafeZoneAction, long, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowed)||
|[static IsActionAllowed(BoundingSphere, MySafeZoneAction, long, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowed)||
|[static IsActionAllowed(Vector3D, MySafeZoneAction, long, ulong)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowed)||
|[static IsActionAllowed(MyCubeGrid, Vector3I, Vector3I, MySafeZoneAction, long)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowed)||
|[static IsActionAllowedFullyInside(MyCubeGrid, MySafeZoneAction, long)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowedFullyInside)||
|[static IsActionAllowedGlobally(MySafeZoneAction)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowedGlobally)||
|[static IsActionAllowedNoChecks(List<MySafeZone>, Vector3D, MySafeZoneAction, long)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsActionAllowedNoChecks)||
|[static IsInSafezone(long, MySafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsInSafezone)||
|[static IsInSafezone(long, List<MySafeZone>)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsInSafezone)||
|[static IsPlayerValid(ulong, long, out MyIdentity, out MyCubeBlock)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsPlayerValid)|Validates player and beacon associated with beacon id.|
|[static IsRecentlyAddedOrRemoved(MyEntity)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsRecentlyAddedOrRemoved)||
|[static IsSafeZoneColliding(long, MatrixD, MySafeZoneShape, float, Vector3)](Sandbox.Game.Entities.MySessionComponentSafeZones@IsSafeZoneColliding)||
|[static RemoveSafeZone(MySafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@RemoveSafeZone)||
|[static RequestCreateSafeZone(Vector3D)](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestCreateSafeZone)||
|[static RequestDeleteSafeZone(long)](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestDeleteSafeZone)||
|[static RequestUpdateGlobalSafeZone()](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestUpdateGlobalSafeZone)||
|[static RequestUpdateSafeZone(MyObjectBuilder_SafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestUpdateSafeZone)||
|[static RequestUpdateSafeZone_Player(long, MyObjectBuilder_SafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestUpdateSafeZone_Player)|Updates safe zone of a beacon with new settings set inside of the object builder|
|[static RequestUpdateSafeZonePlayer(long, MyObjectBuilder_SafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestUpdateSafeZonePlayer)||
|[static RequestUpdateSafeZoneRadius_Player(long, long, float)](Sandbox.Game.Entities.MySessionComponentSafeZones@RequestUpdateSafeZoneRadius_Player)||
|[static UpdateGlobalSafeZone_Implementation(MySafeZoneAction)](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateGlobalSafeZone_Implementation)||
|[static UpdateSafeZone(MyObjectBuilder_SafeZone, bool)](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateSafeZone)|Updates save zone with data from object builder. Use only on server|
|[static UpdateSafeZone_Implementation(MyObjectBuilder_SafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateSafeZone_Implementation)||
|[static UpdateSafeZone_ImplementationPlayer(long, MyObjectBuilder_SafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateSafeZone_ImplementationPlayer)||
|[static UpdateSafeZonePlayer_Implementation(long, MyObjectBuilder_SafeZone)](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateSafeZonePlayer_Implementation)||
|[static UpdateSafeZoneRadius_ImplementationPlayer(long, long, float)](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateSafeZoneRadius_ImplementationPlayer)||
|[GetObjectBuilder()](Sandbox.Game.Entities.MySessionComponentSafeZones@GetObjectBuilder)||
|[Init(MyObjectBuilder_SessionComponent)](Sandbox.Game.Entities.MySessionComponentSafeZones@Init)||
|[LoadData()](Sandbox.Game.Entities.MySessionComponentSafeZones@LoadData)||
|[UpdateAfterSimulation()](Sandbox.Game.Entities.MySessionComponentSafeZones@UpdateAfterSimulation)||
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

