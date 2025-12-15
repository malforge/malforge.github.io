**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridJumpDriveSystem
```

Interface for MyGridJumpDriveSystem in IMyCubeGrid

## Properties

|Member|Description|
|---|---|
|[IsJumping](VRage.Game.ModAPI.IMyGridJumpDriveSystem@IsJumping)|True if the grid is in the animation to jump|
|[Jumped](VRage.Game.ModAPI.IMyGridJumpDriveSystem@Jumped)|True when the grid finally teleports|

## Methods

|Member|Description|
|---|---|
|[AbortJump(int)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@AbortJump)|Ends the jump for the provided reason 0 = None, 1 = Static, 2 = Locked, 3 = ShortDistance, 4 = AlreadyJumping, 5 = NoLocation, 6 = Other|
|[FindSuitableJumpLocation(Vector3D)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@FindSuitableJumpLocation)|Gets a safe position at the desired location (not overlapping stuff)|
|[GetJumpDriveDirection()](VRage.Game.ModAPI.IMyGridJumpDriveSystem@GetJumpDriveDirection)|Gets the direction vector the jump will occur (includes magnitude)|
|[GetJumpDriveDirectionNormalized()](VRage.Game.ModAPI.IMyGridJumpDriveSystem@GetJumpDriveDirectionNormalized)|Gets the normalized direction the jump will occur|
|[GetJumpDriveTarget()](VRage.Game.ModAPI.IMyGridJumpDriveSystem@GetJumpDriveTarget)|Gets the target position the jump is attempting to reach|
|[GetMaxJumpDistance(long)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@GetMaxJumpDistance)|Gets the maximum possible jump distance with the current loadout|
|[GetMinJumpDistance(long)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@GetMinJumpDistance)|Gets the minimum possible jump distance with the current loadout|
|[GetRemainingJumpTime()](VRage.Game.ModAPI.IMyGridJumpDriveSystem@GetRemainingJumpTime)|Gets the time until the jump finally occurs|
|[IsJumpValid(long)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@IsJumpValid)|True if the grid could jump (does not check obstacles)|
|[Jump(Vector3D, long, float)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@Jump)|Makes the grid begin the jumping sequence (Call on server only!)|
|[PerformJump(Vector3D)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@PerformJump)|Performs a jump without the delay or animation (Call on server only!)|
|[RequestJump(string, Vector3D, long, BoundingBoxD?, float, long?)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@RequestJump)|Requests the pilot or local player to jump (Prompts the pilot with the jump UI, they can cancel the jump or say yes)|
|[RequestJump(Vector3D, long, float, long?)](VRage.Game.ModAPI.IMyGridJumpDriveSystem@RequestJump)|Requests the pilot or local player to jump (Prompts the pilot with the jump UI, they can cancel the jump or say yes)|

