**Assembly:** Sandbox.Game.dll

```csharp
public class MyHud: MySessionComponentBase, IMyUserInputComponent
```

## Fields

|Member|Description|
|---|---|
|[ComponentType](VRage.Game.Components.MySessionComponentBase@ComponentType)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[DebugName](VRage.Game.Components.MySessionComponentBase@DebugName)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Priority](VRage.Game.Components.MySessionComponentBase@Priority)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Properties

|Member|Description|
|---|---|
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
|[MySessionComponentBase()](VRage.Game.Components.MySessionComponentBase@.ctor)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Methods

|Member|Description|
|---|---|
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

