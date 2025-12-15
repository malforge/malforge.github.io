**Assembly:** Sandbox.Game.dll

```csharp
public class MySphericalNaturalGravityComponent: MyGravityProviderComponent, IMyComponentBase, IMyEntityComponentBase, IMyGravityProvider, IMyNaturalGravityComponent, IMySphericalNaturalGravityComponent
```

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[ComponentTypeDebugString](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@ComponentTypeDebugString)||
|[GravityLimit](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@GravityLimit)||
|[GravityLimitSq](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@GravityLimitSq)||
|[IsWorking](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@IsWorking)||
|[Position](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@Position)||
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](Sandbox.Game.Entities.MyGravityProviderComponent@ComponentTypeDebugString)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Falloff](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@Falloff)|Gravity falloff between minRadius and maxRadius<br /><br />_Inherited from [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent)_|
|[GravityLimit](VRage.Game.ModAPI.IMyNaturalGravityComponent@GravityLimit)|Gets distance between Position of gravity provider, and it's most distant point<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[GravityLimit](Sandbox.Game.Entities.MyGravityProviderComponent@GravityLimit)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[Intensity](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@Intensity)|Gravity strength<br /><br />_Inherited from [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent)_|
|[IsWorking](VRage.Game.ModAPI.IMyNaturalGravityComponent@IsWorking)|Gets whither block is working or not<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[IsWorking](Sandbox.Game.Entities.IMyGravityProvider@IsWorking)|_Inherited from [IMyGravityProvider](Sandbox.Game.Entities.IMyGravityProvider)_|
|[IsWorking](Sandbox.Game.Entities.MyGravityProviderComponent@IsWorking)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[MaxRadius](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@MaxRadius)|Max gravity radius at lowest intensity<br /><br />_Inherited from [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent)_|
|[MinRadius](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent@MinRadius)|Minimum gravity radius before gravity intensity begins to decrease<br /><br />_Inherited from [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent)_|
|[Position](VRage.Game.ModAPI.IMyNaturalGravityComponent@Position)|_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MySphericalNaturalGravityComponent(double, double, double, double)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CalculateGravityLimit()](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@CalculateGravityLimit)||
|[DoesTrajectoryIntersectNaturalGravity(RayD, double)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@DoesTrajectoryIntersectNaturalGravity)||
|[GetGravityMultiplier(Vector3D)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@GetGravityMultiplier)||
|[GetProxyAABB(out BoundingBoxD)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@GetProxyAABB)||
|[GetWorldGravity(Vector3D)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@GetWorldGravity)||
|[GetWorldGravityNormalized(ref Vector3D)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@GetWorldGravityNormalized)||
|[IsPositionInRange(Vector3D)](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@IsPositionInRange)||
|[OnAddedToContainer()](Sandbox.Game.Entities.MySphericalNaturalGravityComponent@OnAddedToContainer)||
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[DoesTrajectoryIntersectNaturalGravity(RayD, double)](Sandbox.Game.Entities.MyGravityProviderComponent@DoesTrajectoryIntersectNaturalGravity)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetGravityMultiplier(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetGravityMultiplier)|Get gravity scalar<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[GetGravityMultiplier(Vector3D)](Sandbox.Game.Entities.IMyGravityProvider@GetGravityMultiplier)|_Inherited from [IMyGravityProvider](Sandbox.Game.Entities.IMyGravityProvider)_|
|[GetGravityMultiplier(Vector3D)](Sandbox.Game.Entities.MyGravityProviderComponent@GetGravityMultiplier)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[GetProxyAABB(out BoundingBoxD)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetProxyAABB)|Get bounding box around gravity provider<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[GetProxyAABB(out BoundingBoxD)](Sandbox.Game.Entities.IMyGravityProvider@GetProxyAABB)|_Inherited from [IMyGravityProvider](Sandbox.Game.Entities.IMyGravityProvider)_|
|[GetProxyAABB(out BoundingBoxD)](Sandbox.Game.Entities.MyGravityProviderComponent@GetProxyAABB)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[GetWorldGravity(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@GetWorldGravity)|Gets gravity vector<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[GetWorldGravity(Vector3D)](Sandbox.Game.Entities.IMyGravityProvider@GetWorldGravity)|_Inherited from [IMyGravityProvider](Sandbox.Game.Entities.IMyGravityProvider)_|
|[GetWorldGravity(Vector3D)](Sandbox.Game.Entities.MyGravityProviderComponent@GetWorldGravity)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[GetWorldGravityNormalized(ref Vector3D)](Sandbox.Game.Entities.MyGravityProviderComponent@GetWorldGravityNormalized)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsPositionInRange(Vector3D)](VRage.Game.ModAPI.IMyNaturalGravityComponent@IsPositionInRange)|Tests if the specified point is within the gravity of this entity.<br /><br />_Inherited from [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)_|
|[IsPositionInRange(Vector3D)](Sandbox.Game.Entities.IMyGravityProvider@IsPositionInRange)|Tests if the specified point is within the gravity of this entity.<br /><br />_Inherited from [IMyGravityProvider](Sandbox.Game.Entities.IMyGravityProvider)_|
|[IsPositionInRange(Vector3D)](Sandbox.Game.Entities.MyGravityProviderComponent@IsPositionInRange)|_Inherited from [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)_|
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

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* [IMyGravityProvider](Sandbox.Game.Entities.IMyGravityProvider)  
* [IMyNaturalGravityComponent](VRage.Game.ModAPI.IMyNaturalGravityComponent)  
* [IMySphericalNaturalGravityComponent](VRage.Game.ModAPI.IMySphericalNaturalGravityComponent)

