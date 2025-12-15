**Assembly:** Sandbox.Game.dll

```csharp
public class MyPathRecorderComponent: MyEventProxyEntityComponent, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner, IMyTerminalControlsProviderComponent, IMyPathRecorderComponent, IMyPathRecorderComponent
```

## Fields

|Member|Description|
|---|---|
|[DetailedInfo](Sandbox.Game.EntityComponents.MyPathRecorderComponent@DetailedInfo)||
|[ErrorsInTerminal](Sandbox.Game.EntityComponents.MyPathRecorderComponent@ErrorsInTerminal)||
|[Waypoints](Sandbox.Game.EntityComponents.MyPathRecorderComponent@Waypoints)||
|[SyncType](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@SyncType)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[IsPlayingChanged](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsPlayingChanged)||
|[IsRecordingChanged](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsRecordingChanged)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[IsPlayingChanged](Sandbox.ModAPI.IMyPathRecorderComponent@IsPlayingChanged)|Event triggered when IsPlaying changes<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|
|[IsRecordingChanged](Sandbox.ModAPI.IMyPathRecorderComponent@IsRecordingChanged)|Event triggered when IsRecording changes<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|

## Properties

|Member|Description|
|---|---|
|[BeaconDisplayText](Sandbox.Game.EntityComponents.MyPathRecorderComponent@BeaconDisplayText)||
|[BeaconWorldPosition](Sandbox.Game.EntityComponents.MyPathRecorderComponent@BeaconWorldPosition)||
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyPathRecorderComponent@ComponentTypeDebugString)||
|[IsPlaying](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsPlaying)||
|[IsPowered](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsPowered)||
|[IsRecording](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsRecording)||
|[MinimalDistance](Sandbox.Game.EntityComponents.MyPathRecorderComponent@MinimalDistance)||
|[RecordInterval](Sandbox.Game.EntityComponents.MyPathRecorderComponent@RecordInterval)||
|[RepeatPath](Sandbox.Game.EntityComponents.MyPathRecorderComponent@RepeatPath)||
|[ShowPath](Sandbox.Game.EntityComponents.MyPathRecorderComponent@ShowPath)||
|[ShowSelectedPoints](Sandbox.Game.EntityComponents.MyPathRecorderComponent@ShowSelectedPoints)||
|[TerminalControlCreationPriority](Sandbox.Game.EntityComponents.MyPathRecorderComponent@TerminalControlCreationPriority)||
|[AttachSyncToEntity](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@AttachSyncToEntity)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeaconDisplayText](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@BeaconDisplayText)|Gets Beacon display text<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[BeaconEntityId](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@BeaconEntityId)|Entity of beacon in which the waypoints are in relation to<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[BeaconWorldPosition](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@BeaconWorldPosition)|Gets BeaconWorldPosition<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsPlaying](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@IsPlaying)|Gets bool if the PR block is playing<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[IsRecording](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@IsRecording)|Get bool if the PR block is recording<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[MinimalDistance](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@MinimalDistance)|Gets/sets minimal distance between waypoints for automatic recording to record new waypoint<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RecordInterval](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@RecordInterval)|Gets/sets record interval. Sets how often the block tries to records its position as a waypoint. Operates every 100 frames<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RepeatPath](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@RepeatPath)|Repeat path toggle<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[ShowPath](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@ShowPath)|Gets/sets if block is showing path on clients screen<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[ShowSelectedPoints](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@ShowSelectedPoints)|Gets/sets if block is showing points, selected by client on his screen<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyPathRecorderComponent()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@.ctor)||
|[MyEventProxyEntityComponent()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@.ctor)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[AddWaypoint(IMyAutopilotWaypoint)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@AddWaypoint)||
|[CreateTerminalControls<T>()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@CreateTerminalControls{T})||
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@Deserialize)||
|[DrawPath()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@DrawPath)||
|[GetWaypoints(List<IMyAutopilotWaypoint>)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@GetWaypoints)||
|[Init(MyComponentDefinitionBase)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@Init)||
|[IsPathShown()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsPathShown)||
|[IsSerialized()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@IsSerialized)||
|[OnAddedToContainer()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@OnBeforeRemovedFromContainer)||
|[OnRemovedFromScene()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@OnRemovedFromScene)||
|[Play()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@Play)||
|[Record()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@Record)||
|[RefreshErrors(bool)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@RefreshErrors)||
|[RemoveBeacon()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@RemoveBeacon)||
|[RemoveWaypoint(IMyAutopilotWaypoint)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@RemoveWaypoint)||
|[ReverseOrder()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@ReverseOrder)||
|[Serialize(bool)](Sandbox.Game.EntityComponents.MyPathRecorderComponent@Serialize)||
|[StopPlay()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@StopPlay)||
|[StopRecord()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@StopRecord)||
|[UpdateAfterSimulation100()](Sandbox.Game.EntityComponents.MyPathRecorderComponent@UpdateAfterSimulation100)||
|[AddWaypoint(IMyAutopilotWaypoint)](Sandbox.ModAPI.IMyPathRecorderComponent@AddWaypoint)|Adds a waypoint unless the waypoint limit is already reached<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|
|[DeleteAllWaypoints()](Sandbox.ModAPI.IMyPathRecorderComponent@DeleteAllWaypoints)|Deletes all waypoints<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetWaypoints(List<IMyAutopilotWaypoint>)](Sandbox.ModAPI.IMyPathRecorderComponent@GetWaypoints)|Gets list of waypoints in this component<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|
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
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@OnBeforeRemovedFromContainer)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Play()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@Play)|Starts playing current waypoints<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[Record()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@Record)|Starts recording<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RemoveBeacon()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@RemoveBeacon)|Sets BeaconEntityId = 0<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RemoveWaypoint(IMyAutopilotWaypoint)](Sandbox.ModAPI.IMyPathRecorderComponent@RemoveWaypoint)|Removes waypoint<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|
|[ReverseOrder()](Sandbox.ModAPI.IMyPathRecorderComponent@ReverseOrder)|Reverses order of waypoints<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[StopPlay()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@StopPlay)|Stops playing current waypoints<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[StopRecord()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@StopRecord)|Stops recording<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* [IMyPathRecorderComponent](Sandbox.ModAPI.IMyPathRecorderComponent)  
* [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)  
* IMyTerminalControlsProviderComponent <sub>prohibited</sub>

