**Assembly:** Sandbox.Game.dll

```csharp
public class MyLight
```

## Properties

|Member|Description|
|---|---|
|[CastShadows](Sandbox.Game.Lights.MyLight@CastShadows)||
|[Color](Sandbox.Game.Lights.MyLight@Color)||
|[DiffuseFactor](Sandbox.Game.Lights.MyLight@DiffuseFactor)||
|[Falloff](Sandbox.Game.Lights.MyLight@Falloff)|Exponential falloff (1 = linear, 2 = quadratic, etc)|
|[GlareIntensity](Sandbox.Game.Lights.MyLight@GlareIntensity)||
|[GlareMaxDistance](Sandbox.Game.Lights.MyLight@GlareMaxDistance)||
|[GlareOn](Sandbox.Game.Lights.MyLight@GlareOn)||
|[GlareQueryFreqMinMs](Sandbox.Game.Lights.MyLight@GlareQueryFreqMinMs)||
|[GlareQueryFreqRndMs](Sandbox.Game.Lights.MyLight@GlareQueryFreqRndMs)||
|[GlareQueryShift](Sandbox.Game.Lights.MyLight@GlareQueryShift)||
|[GlareQuerySize](Sandbox.Game.Lights.MyLight@GlareQuerySize)||
|[GlareSize](Sandbox.Game.Lights.MyLight@GlareSize)||
|[GlareType](Sandbox.Game.Lights.MyLight@GlareType)||
|[GlossFactor](Sandbox.Game.Lights.MyLight@GlossFactor)||
|[Intensity](Sandbox.Game.Lights.MyLight@Intensity)||
|[LightOn](Sandbox.Game.Lights.MyLight@LightOn)|If true, we use the light in lighting calculation. Otherwise it's like turned off, but still in the buffer.|
|[LightSourceType](Sandbox.Game.Lights.MyLight@LightSourceType)||
|[LightType](Sandbox.Game.Lights.MyLight@LightType)||
|[ParentID](Sandbox.Game.Lights.MyLight@ParentID)||
|[PointLightOffset](Sandbox.Game.Lights.MyLight@PointLightOffset)||
|[Position](Sandbox.Game.Lights.MyLight@Position)||
|[Range](Sandbox.Game.Lights.MyLight@Range)||
|[ReflectorColor](Sandbox.Game.Lights.MyLight@ReflectorColor)||
|[ReflectorConeDegrees](Sandbox.Game.Lights.MyLight@ReflectorConeDegrees)|Sets reflector cone angle in degrees, minimum is 0, teoretical maximum is 180|
|[ReflectorConeMaxAngleCos](Sandbox.Game.Lights.MyLight@ReflectorConeMaxAngleCos)||
|[ReflectorConeRadians](Sandbox.Game.Lights.MyLight@ReflectorConeRadians)|Sets reflector cone angle in degrees, minimum is 0, teoretical maximum is PI|
|[ReflectorDiffuseFactor](Sandbox.Game.Lights.MyLight@ReflectorDiffuseFactor)||
|[ReflectorDirection](Sandbox.Game.Lights.MyLight@ReflectorDirection)||
|[ReflectorFalloff](Sandbox.Game.Lights.MyLight@ReflectorFalloff)||
|[ReflectorGlossFactor](Sandbox.Game.Lights.MyLight@ReflectorGlossFactor)||
|[ReflectorIntensity](Sandbox.Game.Lights.MyLight@ReflectorIntensity)|Reflector parameters are also parameters for spot light|
|[ReflectorOn](Sandbox.Game.Lights.MyLight@ReflectorOn)||
|[ReflectorRange](Sandbox.Game.Lights.MyLight@ReflectorRange)||
|[ReflectorTexture](Sandbox.Game.Lights.MyLight@ReflectorTexture)||
|[ReflectorUp](Sandbox.Game.Lights.MyLight@ReflectorUp)||
|[RenderObjectID](Sandbox.Game.Lights.MyLight@RenderObjectID)||
|[SubGlares](Sandbox.Game.Lights.MyLight@SubGlares)||

## Constructors

|Member|Description|
|---|---|
|[MyLight()](Sandbox.Game.Lights.MyLight@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Clear()](Sandbox.Game.Lights.MyLight@Clear)|Can be called only from MyLights.RemoveLight.|
|[MarkPositionDirty()](Sandbox.Game.Lights.MyLight@MarkPositionDirty)||
|[SpotlightNotTooLarge(float, float)](Sandbox.Game.Lights.MyLight@SpotlightNotTooLarge)|When setting Reflector properties, use this function to test whether properties are in bounds and light AABB is not too large. Properties which affects calculations are ReflectorRange and ReflectorConeMaxAngleCos (ReflectorConeDegrees, ReflectorConeRadians)|
|[Start(Vector3D, Vector4, float, string)](Sandbox.Game.Lights.MyLight@Start)||
|[Start(Vector4, float, string)](Sandbox.Game.Lights.MyLight@Start)||
|[Start(string)](Sandbox.Game.Lights.MyLight@Start)|IMPORTANT: This class isn't realy inicialized by constructor, but by Start()|
|[UpdateLight()](Sandbox.Game.Lights.MyLight@UpdateLight)||
|[UpdateReflectorRangeAndAngle(float, float)](Sandbox.Game.Lights.MyLight@UpdateReflectorRangeAndAngle)|Use when setting both values and previous state of both value is undefined|

