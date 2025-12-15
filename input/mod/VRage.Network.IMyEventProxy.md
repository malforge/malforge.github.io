**Assembly:** VRage.dll

```csharp
public interface IMyEventProxy: IMyEventOwner
```

Interface which only marks class as event owner. Object itself must be replicated in network to allow raising events. If you considering to add this to object, it's probably wrong and you should use static events in most cases. This is commonly implemented only by entities which has it's external replicable.

**Implements:**  
* IMyEventOwner <sub>prohibited</sub>

**Inheritors:**  
* [MyAdvancedDoor](Sandbox.Game.Entities.MyAdvancedDoor)  
* [MyAirtightDoorGeneric](Sandbox.Game.Entities.MyAirtightDoorGeneric)  
* [MyAirtightHangarDoor](Sandbox.Game.Entities.MyAirtightHangarDoor)  
* [MyAirtightSlideDoor](Sandbox.Game.Entities.MyAirtightSlideDoor)  
* [MyAtmosphereDetectorComponent](Sandbox.Game.EntityComponents.MyAtmosphereDetectorComponent)  
* [MyAutopilotComponent](Sandbox.Game.EntityComponents.MyAutopilotComponent)  
* [MyBatteryBlock](Sandbox.Game.Entities.MyBatteryBlock)  
* [MyCameraBlock](Sandbox.Game.Entities.MyCameraBlock)  
* [MyCargoContainer](Sandbox.Game.Entities.MyCargoContainer)  
* [MyCargoContainerInventoryBagEntity](Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity)  
* [MyCharacterDetectorComponent](Sandbox.Game.Entities.Character.Components.MyCharacterDetectorComponent)  
* [MyCharacterJetpackComponent](Sandbox.Game.Entities.Character.Components.MyCharacterJetpackComponent)  
* [MyCharacterOxygenComponent](Sandbox.Game.Entities.Character.Components.MyCharacterOxygenComponent)  
* [MyCharacterRagdollComponent](Sandbox.Game.Entities.Character.Components.MyCharacterRagdollComponent)  
* [MyCharacterRaycastDetectorComponent](Sandbox.Game.Entities.Character.Components.MyCharacterRaycastDetectorComponent)  
* [MyCharacterShapecastDetectorComponent](Sandbox.Game.Entities.Character.Components.MyCharacterShapecastDetectorComponent)  
* [MyCharacterSoundComponent](Sandbox.Game.Components.MyCharacterSoundComponent)  
* [MyCharacterStatComponent](Sandbox.Game.Components.MyCharacterStatComponent)  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyConveyorSorter](Sandbox.Game.Entities.MyConveyorSorter)  
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)  
* [MyDataBroadcaster](Sandbox.Game.Entities.MyDataBroadcaster)  
* [MyDoor](Sandbox.Game.Entities.MyDoor)  
* [MyDoorBase](Sandbox.Game.Entities.MyDoorBase)  
* [MyEntityReverbDetectorComponent](Sandbox.Game.EntityComponents.MyEntityReverbDetectorComponent)  
* [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)  
* [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)  
* [MyFloatingObject](Sandbox.Game.Entities.MyFloatingObject)  
* [MyForageableEntity](Sandbox.Game.Entities.MyForageableEntity)  
* [MyFueledPowerProducer](Sandbox.Game.Entities.MyFueledPowerProducer)  
* [MyGyro](Sandbox.Game.Entities.MyGyro)  
* [MyInventory](Sandbox.Game.MyInventory)  
* [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)  
* [MyJumpDrive](Sandbox.Game.Entities.MyJumpDrive)  
* [MyLogicalEnvironmentSectorBase](Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase)  
* [MyMeteor](Sandbox.Game.Entities.MyMeteor)  
* [MyModifiableEntity](Sandbox.Game.Entities.MyModifiableEntity)  
* [MyMultiTextPanelComponent](Sandbox.Game.EntityComponents.MyMultiTextPanelComponent)  
* [MyPathRecorderComponent](Sandbox.Game.EntityComponents.MyPathRecorderComponent)  
* [MyPlanet](Sandbox.Game.Entities.MyPlanet)  
* [MyProceduralLogicalSector](Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector)  
* [MyReactor](Sandbox.Game.Entities.MyReactor)  
* [MyReflectorLight](Sandbox.Game.Entities.MyReflectorLight)  
* [MyRemoteControl](Sandbox.Game.Entities.MyRemoteControl)  
* [MySafeZone](Sandbox.Game.Entities.MySafeZone)  
* [MyShipController](Sandbox.Game.Entities.MyShipController)  
* [MyTargetFocusComponent](Sandbox.Game.EntityComponents.MyTargetFocusComponent)  
* [MyTargetLockingBlockComponent](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent)  
* [MyTargetLockingComponent](Sandbox.Game.EntityComponents.MyTargetLockingComponent)  
* [MyThrust](Sandbox.Game.Entities.MyThrust)  
* [MyTurretController](Sandbox.Game.EntityComponents.MyTurretController)  
* [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)  
* [MyVoxelBase](Sandbox.Game.Entities.MyVoxelBase)  
* [MyVoxelMap](Sandbox.Game.Entities.MyVoxelMap)  
* [MyWaypoint](Sandbox.Game.Entities.MyWaypoint)

