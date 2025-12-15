**Assembly:** Sandbox.Game.dll

```csharp
public class MyLightingLogic
```

## Events

|Member|Description|
|---|---|
|[OnEmissivityUpdated](Sandbox.Game.EntityComponents.MyLightingLogic@OnEmissivityUpdated)||
|[OnInitLight](Sandbox.Game.EntityComponents.MyLightingLogic@OnInitLight)||
|[OnIntensityUpdated](Sandbox.Game.EntityComponents.MyLightingLogic@OnIntensityUpdated)||
|[OnPropertiesChanged](Sandbox.Game.EntityComponents.MyLightingLogic@OnPropertiesChanged)||
|[OnRadiusUpdated](Sandbox.Game.EntityComponents.MyLightingLogic@OnRadiusUpdated)||
|[OnUpdateEnabled](Sandbox.Game.EntityComponents.MyLightingLogic@OnUpdateEnabled)||

## Properties

|Member|Description|
|---|---|
|[BlinkIntervalSeconds](Sandbox.Game.EntityComponents.MyLightingLogic@BlinkIntervalSeconds)||
|[BlinkIntervalSecondsBounds](Sandbox.Game.EntityComponents.MyLightingLogic@BlinkIntervalSecondsBounds)||
|[BlinkLength](Sandbox.Game.EntityComponents.MyLightingLogic@BlinkLength)||
|[BlinkLengthBounds](Sandbox.Game.EntityComponents.MyLightingLogic@BlinkLengthBounds)||
|[BlinkOffset](Sandbox.Game.EntityComponents.MyLightingLogic@BlinkOffset)||
|[BlinkOffsetBounds](Sandbox.Game.EntityComponents.MyLightingLogic@BlinkOffsetBounds)||
|[BulbColor](Sandbox.Game.EntityComponents.MyLightingLogic@BulbColor)||
|[Color](Sandbox.Game.EntityComponents.MyLightingLogic@Color)||
|[CurrentLightPower](Sandbox.Game.EntityComponents.MyLightingLogic@CurrentLightPower)||
|[Falloff](Sandbox.Game.EntityComponents.MyLightingLogic@Falloff)||
|[FalloffBounds](Sandbox.Game.EntityComponents.MyLightingLogic@FalloffBounds)||
|[HasSubPartLights](Sandbox.Game.EntityComponents.MyLightingLogic@HasSubPartLights)||
|[Intensity](Sandbox.Game.EntityComponents.MyLightingLogic@Intensity)||
|[IntensityBounds](Sandbox.Game.EntityComponents.MyLightingLogic@IntensityBounds)||
|[IsEmissiveMaterialDirty](Sandbox.Game.EntityComponents.MyLightingLogic@IsEmissiveMaterialDirty)||
|[IsPositionDirty](Sandbox.Game.EntityComponents.MyLightingLogic@IsPositionDirty)||
|[IsPreview](Sandbox.Game.EntityComponents.MyLightingLogic@IsPreview)||
|[IsReflector](Sandbox.Game.EntityComponents.MyLightingLogic@IsReflector)||
|[LightLocalDatas](Sandbox.Game.EntityComponents.MyLightingLogic@LightLocalDatas)||
|[Lights](Sandbox.Game.EntityComponents.MyLightingLogic@Lights)||
|[NeedPerFrameUpdate](Sandbox.Game.EntityComponents.MyLightingLogic@NeedPerFrameUpdate)||
|[NeedsRecreateLights](Sandbox.Game.EntityComponents.MyLightingLogic@NeedsRecreateLights)||
|[Offset](Sandbox.Game.EntityComponents.MyLightingLogic@Offset)||
|[OffsetBounds](Sandbox.Game.EntityComponents.MyLightingLogic@OffsetBounds)||
|[Radius](Sandbox.Game.EntityComponents.MyLightingLogic@Radius)||
|[RadiusBounds](Sandbox.Game.EntityComponents.MyLightingLogic@RadiusBounds)||
|[ReflectorConeDegrees](Sandbox.Game.EntityComponents.MyLightingLogic@ReflectorConeDegrees)||
|[ReflectorRadius](Sandbox.Game.EntityComponents.MyLightingLogic@ReflectorRadius)||
|[ReflectorRadiusBounds](Sandbox.Game.EntityComponents.MyLightingLogic@ReflectorRadiusBounds)||

## Constructors

|Member|Description|
|---|---|
|[MyLightingLogic(MyFunctionalBlock, MyLightingBlockDefinition, IMyLightingLogicSync)](Sandbox.Game.EntityComponents.MyLightingLogic@.ctor)||
|[MyLightingLogic(MyFunctionalBlock, MyHeatVentBlockDefinition, IMyLightingLogicSync)](Sandbox.Game.EntityComponents.MyLightingLogic@.ctor)||
|[MyLightingLogic(MyFunctionalBlock, MySearchlightDefinition, IMyLightingLogicSync)](Sandbox.Game.EntityComponents.MyLightingLogic@.ctor)||
|[MyLightingLogic(MyFunctionalBlock, IMyLightingComponentDefinition, IMyLightingLogicSync)](Sandbox.Game.EntityComponents.MyLightingLogic@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CloseLights()](Sandbox.Game.EntityComponents.MyLightingLogic@CloseLights)||
|[ComputeBulbColor()](Sandbox.Game.EntityComponents.MyLightingLogic@ComputeBulbColor)||
|[CreateLights()](Sandbox.Game.EntityComponents.MyLightingLogic@CreateLights)||
|[Initialize()](Sandbox.Game.EntityComponents.MyLightingLogic@Initialize)|This method must be called in the block's Init() after base.Init() to ensure proper initialization order.|
|[OnAddedToScene()](Sandbox.Game.EntityComponents.MyLightingLogic@OnAddedToScene)||
|[OnModelChange()](Sandbox.Game.EntityComponents.MyLightingLogic@OnModelChange)||
|[RecreateLights()](Sandbox.Game.EntityComponents.MyLightingLogic@RecreateLights)||
|[UpdateAfterSimulation(Vector3, MatrixD)](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateAfterSimulation)||
|[UpdateAfterSimulation()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateAfterSimulation)||
|[UpdateEmissiveMaterial()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateEmissiveMaterial)||
|[UpdateEnabled()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateEnabled)||
|[UpdateLightBlink()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateLightBlink)||
|[UpdateLightData()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateLightData)||
|[UpdateLightPosition()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateLightPosition)||
|[UpdateLightPosition(Vector3, MatrixD)](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateLightPosition)||
|[UpdateLightProperties()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateLightProperties)||
|[UpdateOnceBeforeFrame()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateOnceBeforeFrame)||
|[UpdateParents()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateParents)||
|[UpdateVisual()](Sandbox.Game.EntityComponents.MyLightingLogic@UpdateVisual)||

