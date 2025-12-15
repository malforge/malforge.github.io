**Assembly:** VRage.Game.dll

```csharp
public abstract class MySessionComponentBase: IMyUserInputComponent
```

## Fields

|Member|Description|
|---|---|
|[ComponentType](VRage.Game.Components.MySessionComponentBase@ComponentType)||
|[DebugName](VRage.Game.Components.MySessionComponentBase@DebugName)||
|[Priority](VRage.Game.Components.MySessionComponentBase@Priority)||

## Properties

|Member|Description|
|---|---|
|[Definition](VRage.Game.Components.MySessionComponentBase@Definition)||
|[Dependencies](VRage.Game.Components.MySessionComponentBase@Dependencies)||
|[Initialized](VRage.Game.Components.MySessionComponentBase@Initialized)||
|[IsRequiredByGame](VRage.Game.Components.MySessionComponentBase@IsRequiredByGame)|Indicates whether a session component should be used in current configuration. Example: MyDestructionData component returns true only when game uses Havok Destruction|
|[IsServerOnly](VRage.Game.Components.MySessionComponentBase@IsServerOnly)|Is server only is used for client request of the world. if the component is server only, it's not sent to the client on world request.|
|[Loaded](VRage.Game.Components.MySessionComponentBase@Loaded)||
|[ModContext](VRage.Game.Components.MySessionComponentBase@ModContext)||
|[ObjectBuilderType](VRage.Game.Components.MySessionComponentBase@ObjectBuilderType)||
|[Session](VRage.Game.Components.MySessionComponentBase@Session)||
|[UpdateOnPause](VRage.Game.Components.MySessionComponentBase@UpdateOnPause)||
|[UpdateOrder](VRage.Game.Components.MySessionComponentBase@UpdateOrder)||

## Constructors

|Member|Description|
|---|---|
|[MySessionComponentBase()](VRage.Game.Components.MySessionComponentBase@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AfterLoadData()](VRage.Game.Components.MySessionComponentBase@AfterLoadData)||
|[BeforeStart()](VRage.Game.Components.MySessionComponentBase@BeforeStart)||
|[Draw()](VRage.Game.Components.MySessionComponentBase@Draw)||
|[GetObjectBuilder()](VRage.Game.Components.MySessionComponentBase@GetObjectBuilder)||
|[HandleInput()](VRage.Game.Components.MySessionComponentBase@HandleInput)||
|[Init(MyObjectBuilder_SessionComponent)](VRage.Game.Components.MySessionComponentBase@Init)||
|[InitFromDefinition(MySessionComponentDefinition)](VRage.Game.Components.MySessionComponentBase@InitFromDefinition)||
|[LoadData()](VRage.Game.Components.MySessionComponentBase@LoadData)||
|[SaveData()](VRage.Game.Components.MySessionComponentBase@SaveData)||
|[SetUpdateOrder(MyUpdateOrder)](VRage.Game.Components.MySessionComponentBase@SetUpdateOrder)||
|[Simulate()](VRage.Game.Components.MySessionComponentBase@Simulate)||
|[ToString()](VRage.Game.Components.MySessionComponentBase@ToString)||
|[UnloadDataConditional()](VRage.Game.Components.MySessionComponentBase@UnloadDataConditional)||
|[UpdateAfterSimulation()](VRage.Game.Components.MySessionComponentBase@UpdateAfterSimulation)||
|[UpdateBeforeSimulation()](VRage.Game.Components.MySessionComponentBase@UpdateBeforeSimulation)||
|[UpdatedBeforeInit()](VRage.Game.Components.MySessionComponentBase@UpdatedBeforeInit)||
|[UpdatingStopped()](VRage.Game.Components.MySessionComponentBase@UpdatingStopped)||
|[HandleInput()](VRage.Game.Components.Interfaces.IMyUserInputComponent@HandleInput)|_Inherited from [IMyUserInputComponent](VRage.Game.Components.Interfaces.IMyUserInputComponent)_|

**Implements:**  
* [IMyUserInputComponent](VRage.Game.Components.Interfaces.IMyUserInputComponent)

**Inheritors:**  
* [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)  
* [MyExplosions](Sandbox.Game.MyExplosions)  
* [MyFloatingObjects](Sandbox.Game.Entities.MyFloatingObjects)  
* [MyGamePruningStructure](Sandbox.Game.Entities.MyGamePruningStructure)  
* [MyHud](Sandbox.Game.Gui.MyHud)  
* [MyLights](Sandbox.Game.Lights.MyLights)  
* [MyMeteorShower](Sandbox.Game.Entities.MyMeteorShower)  
* [MyParticlesManager](VRage.Game.MyParticlesManager)  
* [MyPhysics](Sandbox.Engine.Physics.MyPhysics)  
* [MySessionComponentSafeZones](Sandbox.Game.Entities.MySessionComponentSafeZones)

