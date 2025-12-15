**Assembly:** Sandbox.Game.dll

```csharp
public class MyModStorageComponent: MyModStorageComponentBase, IMyComponentBase, IMyEntityComponentBase, IDictionary<Guid, string>, ICollection<KeyValuePair<Guid, string>>, IEnumerable<KeyValuePair<Guid, string>>, IEnumerable
```

Component that stores custom mod data for an entity. Shared by all mods. NOTE: Create an EntityComponents.sbc with your mod's GUIDs to make sure data is saved. This allows data to remain in the world file until the user removes the mod.

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[Storage](Sandbox.Game.EntityComponents.MyModStorageComponent@Storage)|Store custom mod data here. Use a GUID unique to your mod. Use only system types, not custom types in mod script or game.|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyModStorageComponentBase@ComponentTypeDebugString)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Count](VRage.Game.Components.MyModStorageComponentBase@Count)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsReadOnly](VRage.Game.Components.MyModStorageComponentBase@IsReadOnly)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Item](VRage.Game.Components.MyModStorageComponentBase@Item)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Keys](VRage.Game.Components.MyModStorageComponentBase@Keys)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Values](VRage.Game.Components.MyModStorageComponentBase@Values)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyModStorageComponent()](Sandbox.Game.EntityComponents.MyModStorageComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.EntityComponents.MyModStorageComponent@Deserialize)||
|[GetValue(Guid)](Sandbox.Game.EntityComponents.MyModStorageComponent@GetValue)||
|[IsSerialized()](Sandbox.Game.EntityComponents.MyModStorageComponent@IsSerialized)||
|[RemoveValue(Guid)](Sandbox.Game.EntityComponents.MyModStorageComponent@RemoveValue)||
|[Serialize(bool)](Sandbox.Game.EntityComponents.MyModStorageComponent@Serialize)||
|[SetValue(Guid, string)](Sandbox.Game.EntityComponents.MyModStorageComponent@SetValue)||
|[TryGetValue(Guid, out string)](Sandbox.Game.EntityComponents.MyModStorageComponent@TryGetValue)||
|[Add(KeyValuePair<Guid, string>)](VRage.Game.Components.MyModStorageComponentBase@Add)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Add(Guid, string)](VRage.Game.Components.MyModStorageComponentBase@Add)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Clear()](VRage.Game.Components.MyModStorageComponentBase@Clear)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Contains(KeyValuePair<Guid, string>)](VRage.Game.Components.MyModStorageComponentBase@Contains)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[ContainsKey(Guid)](VRage.Game.Components.MyModStorageComponentBase@ContainsKey)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[CopyTo(KeyValuePair`2[], int)](VRage.Game.Components.MyModStorageComponentBase@CopyTo)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetEnumerator()](VRage.Game.Components.MyModStorageComponentBase@GetEnumerator)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[GetValue(Guid)](VRage.Game.Components.MyModStorageComponentBase@GetValue)|Gets a value from the Storage dictionary with the specified key.<br /><br />_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
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
|[Remove(KeyValuePair<Guid, string>)](VRage.Game.Components.MyModStorageComponentBase@Remove)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Remove(Guid)](VRage.Game.Components.MyModStorageComponentBase@Remove)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[RemoveValue(Guid)](VRage.Game.Components.MyModStorageComponentBase@RemoveValue)|Removes a value with the specified key from the Storage dictionary.<br /><br />_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyModStorageComponentBase@Serialize)|_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetValue(Guid, string)](VRage.Game.Components.MyModStorageComponentBase@SetValue)|Stores a value with the specified key into the Storage dictionary.<br /><br />_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|
|[TryGetValue(Guid, out string)](VRage.Game.Components.MyModStorageComponentBase@TryGetValue)|Tries to a value from the Storage dictionary with the specified key.<br /><br />_Inherited from [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)

**Implements:**  
* [ICollection<KeyValuePair<Guid, string>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=netframework-4.6)  
* [IDictionary<Guid, string>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=netframework-4.6)  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable<KeyValuePair<Guid, string>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

