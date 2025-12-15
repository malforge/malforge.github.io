**Assembly:** SpaceEngineers.ObjectBuilders.dll

```csharp
public class MyObjectBuilder_AutopilotComponentDefinition: MyObjectBuilder_ComponentDefinitionBase
```

## Fields

|Member|Description|
|---|---|
|[AlignToGravity](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@AlignToGravity)||
|[CoastingTestEnabled](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CoastingTestEnabled)||
|[CourseCorrectionMaxDistanceInPrecisionModeGridSizeMultiple](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CourseCorrectionMaxDistanceInPrecisionModeGridSizeMultiple)|Distance from direct line between two waypoints (in multiples of gridSize), at which will the autopilot try to correct with CourseCorrectionMaxThrust% thrust in precision mode|
|[CourseCorrectionMaxDistanceLargeGrid](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CourseCorrectionMaxDistanceLargeGrid)|Distance from direct line between two waypoints, at which will the autopilot try to correct with CourseCorrectionMaxThrust% thrust. Large grid only setting|
|[CourseCorrectionMaxDistanceSmallGrid](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CourseCorrectionMaxDistanceSmallGrid)|Distance from direct line between two waypoints, at which will the autopilot try to correct with CourseCorrectionMaxThrust% thrust. Small grid only setting|
|[CourseCorrectionMaxRemainingRotationBeforeThrust](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CourseCorrectionMaxRemainingRotationBeforeThrust)|Max angle in radians between vectors 'Grid.Forward' and 'NextWaypoint.Forward' or 'Grid.Position - NextWaypoint.Position' when going toward first waypoint before starting thrust|
|[CourseCorrectionMaxRemainingRotationBeforeThrustInPrecisionMode](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CourseCorrectionMaxRemainingRotationBeforeThrustInPrecisionMode)|Max angle in radians between vectors 'Grid.Forward' and 'NextWaypoint.Forward' or 'Grid.Position - NextWaypoint.Position' when going toward first waypoint before starting thrust. In Precision mode|
|[CourseCorrectionMaxThrustPercentage](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@CourseCorrectionMaxThrustPercentage)|Max percentage of thrust dedicated to correcting course toward nearest point on direct line between two traveled points|
|[DefaultPitchAngleDeg](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@DefaultPitchAngleDeg)|Default value of MaxPitchAngle in degrees for newly built block|
|[DefaultRollAngleDeg](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@DefaultRollAngleDeg)|Default value of MaxRollAngle in degrees for newly built block|
|[MaxPitchAngleDeg](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MaxPitchAngleDeg)|When moving to a waypoint in P-Gravity, the grid may pitch up or down by this angle in degrees|
|[MaxRollAngleDeg](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MaxRollAngleDeg)|When moving to a waypoint in P-Gravity, the grid may roll left or right by this angle in degrees|
|[MaxRotationSpeed](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MaxRotationSpeed)|Minimum rotation speed (vanila was about 1.8)|
|[MaxRotationSpeedTresholdRadians](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MaxRotationSpeedTresholdRadians)|Above this value rotation speed will always be MaxRotationSpeed (vanila was infinite)|
|[MinHeightAboveTerrainBounds](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MinHeightAboveTerrainBounds)||
|[MinHeightAlignmentEnabled](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MinHeightAlignmentEnabled)||
|[MinRotationSpeed](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MinRotationSpeed)|Minimum rotation speed (vanila was about 0.05)|
|[MinRotationSpeedThresholdRadians](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@MinRotationSpeedThresholdRadians)|Under this value rotation speed will always be MinRotationSpeed (vanila was 0)|
|[PrecisionModeRotationVelocitySlowFactor](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@PrecisionModeRotationVelocitySlowFactor)|Rotation velocity in precision mode is divided by this value|
|[RotationDeadzone](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@RotationDeadzone)|How many radians remaining to be considered fully rotated|
|[RotationDeadzoneAdaptiveSpeed](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@RotationDeadzoneAdaptiveSpeed)|How many radians remaining to be considered fully rotated. For adaptive speed waypoints|
|[RotationVelocitySlowFactorAutomaticBehavior](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@RotationVelocitySlowFactorAutomaticBehavior)|Rotation velocity is divided by this value|
|[RotationVelocitySlowFactorAutomaticBehaviorTreshold](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@RotationVelocitySlowFactorAutomaticBehaviorTreshold)|Treshold under which grids with AutomaticBehavior (like drones) and target, will divide their torque by RotationVelocitySlowFactorAutomaticBehavior|
|[AvailableInSurvival](VRage.Game.MyObjectBuilder_DefinitionBase@AvailableInSurvival)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[ComponentType](VRage.Game.MyObjectBuilder_ComponentDefinitionBase@ComponentType)|_Inherited from [MyObjectBuilder_ComponentDefinitionBase](VRage.Game.MyObjectBuilder_ComponentDefinitionBase)_|
|[Description](VRage.Game.MyObjectBuilder_DefinitionBase@Description)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DescriptionArgs](VRage.Game.MyObjectBuilder_DefinitionBase@DescriptionArgs)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DisplayName](VRage.Game.MyObjectBuilder_DefinitionBase@DisplayName)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[DLCs](VRage.Game.MyObjectBuilder_DefinitionBase@DLCs)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Enabled](VRage.Game.MyObjectBuilder_DefinitionBase@Enabled)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Icons](VRage.Game.MyObjectBuilder_DefinitionBase@Icons)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Id](VRage.Game.MyObjectBuilder_DefinitionBase@Id)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|
|[Public](VRage.Game.MyObjectBuilder_DefinitionBase@Public)|_Inherited from [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase)_|

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_AutopilotComponentDefinition()](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition@.ctor)||
|[MyObjectBuilder_ComponentDefinitionBase()](VRage.Game.MyObjectBuilder_ComponentDefinitionBase@.ctor)|_Inherited from [MyObjectBuilder_ComponentDefinitionBase](VRage.Game.MyObjectBuilder_ComponentDefinitionBase)_|

## Methods

|Member|Description|
|---|---|
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase) ˃ [MyObjectBuilder_ComponentDefinitionBase](VRage.Game.MyObjectBuilder_ComponentDefinitionBase)

