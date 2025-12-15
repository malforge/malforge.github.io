**Assembly:** Sandbox.Game.dll

```csharp
public class MyProceduralEnvironmentProvider: IMyEnvironmentDataProvider
```

## Fields

|Member|Description|
|---|---|
|[LodFactor](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@LodFactor)||

## Properties

|Member|Description|
|---|---|
|[LogicalSectors](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@LogicalSectors)||
|[Owner](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@Owner)||
|[ProviderId](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@ProviderId)||
|[LogicalSectors](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider@LogicalSectors)|_Inherited from [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)_|

## Constructors

|Member|Description|
|---|---|
|[MyProceduralEnvironmentProvider()](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CloseView(MyProceduralDataView)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@CloseView)||
|[DebugDraw()](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@DebugDraw)||
|[GeSectorWorldParameters(int, int, int, out Vector3D, out Vector3, out Vector3)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@GeSectorWorldParameters)||
|[GetItemView(int, ref Vector2I, ref Vector2I, ref Vector3D)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@GetItemView)||
|[GetLogicalSector(long)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@GetLogicalSector)||
|[GetObjectBuilder()](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@GetObjectBuilder)||
|[GetSeed()](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@GetSeed)||
|[Init(IMyEnvironmentOwner, ref Vector3D, ref Vector3D, ref Vector3D, double, MyObjectBuilder_Base)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@Init)||
|[RevalidateItem(long, int)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@RevalidateItem)||
|[TryGetLogicalSector(int, int, int)](Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider@TryGetLogicalSector)||
|[DebugDraw()](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider@DebugDraw)|_Inherited from [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)_|
|[GetItemView(int, ref Vector2I, ref Vector2I, ref Vector3D)](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider@GetItemView)|_Inherited from [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)_|
|[GetLogicalSector(long)](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider@GetLogicalSector)|_Inherited from [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)_|
|[GetObjectBuilder()](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider@GetObjectBuilder)|_Inherited from [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)_|
|[RevalidateItem(long, int)](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider@RevalidateItem)|_Inherited from [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)_|

**Implements:**  
* [IMyEnvironmentDataProvider](Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider)

