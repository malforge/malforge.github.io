**Assembly:** Sandbox.Game.dll

```csharp
public class MyAutopilotWaypoint: IMyAutopilotWaypoint
```

## Fields

|Member|Description|
|---|---|
|[RelatedMatrixOriginal](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedMatrixOriginal)|Related matrix when recorded. Same as Matrix when no related entity was present|
|[SerializeForCopy](Sandbox.Game.Entities.MyAutopilotWaypoint@SerializeForCopy)||

## Properties

|Member|Description|
|---|---|
|[Actions](Sandbox.Game.Entities.MyAutopilotWaypoint@Actions)||
|[AdaptiveRotationSpeed](Sandbox.Game.Entities.MyAutopilotWaypoint@AdaptiveRotationSpeed)||
|[AreaUp](Sandbox.Game.Entities.MyAutopilotWaypoint@AreaUp)||
|[CanDraw](Sandbox.Game.Entities.MyAutopilotWaypoint@CanDraw)||
|[Coords](Sandbox.Game.Entities.MyAutopilotWaypoint@Coords)|Translation when recorded|
|[DistancePrecisionMultiplier](Sandbox.Game.Entities.MyAutopilotWaypoint@DistancePrecisionMultiplier)||
|[DrawObject](Sandbox.Game.Entities.MyAutopilotWaypoint@DrawObject)||
|[ForceRotation](Sandbox.Game.Entities.MyAutopilotWaypoint@ForceRotation)||
|[IsCorrectRotationNeeded](Sandbox.Game.Entities.MyAutopilotWaypoint@IsCorrectRotationNeeded)||
|[IsPathfindingVertex](Sandbox.Game.Entities.MyAutopilotWaypoint@IsPathfindingVertex)||
|[Matrix](Sandbox.Game.Entities.MyAutopilotWaypoint@Matrix)|Matrix when recorded|
|[Name](Sandbox.Game.Entities.MyAutopilotWaypoint@Name)||
|[PathfindingVertex](Sandbox.Game.Entities.MyAutopilotWaypoint@PathfindingVertex)||
|[RelatedCoordsOriginal](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedCoordsOriginal)|Related Translation when recorded|
|[RelatedEntity](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedEntity)||
|[RelatedEntityId](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedEntityId)||
|[RelatedEntityWorldOffset](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedEntityWorldOffset)||
|[RelatedEntityWorldOffsetOriginal](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedEntityWorldOffsetOriginal)||
|[RelatedMatrixCurrent](Sandbox.Game.Entities.MyAutopilotWaypoint@RelatedMatrixCurrent)||
|[RelativeMatrix](Sandbox.Game.Entities.MyAutopilotWaypoint@RelativeMatrix)|Actual shown position|
|[SelectedForDraw](Sandbox.Game.Entities.MyAutopilotWaypoint@SelectedForDraw)||
|[StoppingTimeMultiplier](Sandbox.Game.Entities.MyAutopilotWaypoint@StoppingTimeMultiplier)||
|[Toolbar](Sandbox.Game.Entities.MyAutopilotWaypoint@Toolbar)||
|[Matrix](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint@Matrix)|Gets matrix representing recorded position and rotation<br /><br />_Inherited from [IMyAutopilotWaypoint](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint)_|
|[Name](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint@Name)|Name of waypoint<br /><br />_Inherited from [IMyAutopilotWaypoint](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint)_|
|[RelatedEntityId](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint@RelatedEntityId)|Sets Id of entity in relation to which the Coords are set<br /><br />_Inherited from [IMyAutopilotWaypoint](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint)_|
|[RelativeMatrix](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint@RelativeMatrix)|Coordinates in relation to relatedEntity<br /><br />_Inherited from [IMyAutopilotWaypoint](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint)_|

## Constructors

|Member|Description|
|---|---|
|[MyAutopilotWaypoint(Vector3D, string, List<MyObjectBuilder_ToolbarItem>, List<int>, bool)](Sandbox.Game.Entities.MyAutopilotWaypoint@.ctor)||
|[MyAutopilotWaypoint(MatrixD, string, List<MyObjectBuilder_ToolbarItem>, List<int>, bool)](Sandbox.Game.Entities.MyAutopilotWaypoint@.ctor)||
|[MyAutopilotWaypoint(Vector3D, string)](Sandbox.Game.Entities.MyAutopilotWaypoint@.ctor)||
|[MyAutopilotWaypoint(Vector3D, MyPositionAndOrientation, long, MyPositionAndOrientation, Vector3D, string)](Sandbox.Game.Entities.MyAutopilotWaypoint@.ctor)||
|[MyAutopilotWaypoint(MyObjectBuilder_AutopilotWaypoint)](Sandbox.Game.Entities.MyAutopilotWaypoint@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static AreEqualByResultCoordinates(MyAutopilotWaypoint, MyAutopilotWaypoint)](Sandbox.Game.Entities.MyAutopilotWaypoint@AreEqualByResultCoordinates)||
|[GetObjectBuilder()](Sandbox.Game.Entities.MyAutopilotWaypoint@GetObjectBuilder)||
|[InitToolbar()](Sandbox.Game.Entities.MyAutopilotWaypoint@InitToolbar)||
|[SetActions(List<Slot>)](Sandbox.Game.Entities.MyAutopilotWaypoint@SetActions)||
|[SetGpsDraw()](Sandbox.Game.Entities.MyAutopilotWaypoint@SetGpsDraw)||

**Implements:**  
* [IMyAutopilotWaypoint](Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint)

