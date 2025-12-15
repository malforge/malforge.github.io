**Assembly:** VRage.Game.dll

```csharp
public interface IMyIdentity
```

Describes player or bot (mods interface)

## Events

|Member|Description|
|---|---|
|[CharacterChanged](VRage.Game.ModAPI.IMyIdentity@CharacterChanged)|Triggered when the player's character changes.|

## Properties

|Member|Description|
|---|---|
|[ColorMask](VRage.Game.ModAPI.IMyIdentity@ColorMask)|The player's model color mask|
|[DisplayName](VRage.Game.ModAPI.IMyIdentity@DisplayName)|Name of player.|
|[IdentityId](VRage.Game.ModAPI.IMyIdentity@IdentityId)|Player's unique identity id.|
|[IsDead](VRage.Game.ModAPI.IMyIdentity@IsDead)|Gets if the player is dead|
|[Model](VRage.Game.ModAPI.IMyIdentity@Model)|Gets the model the player is using.|
|[PlayerId](VRage.Game.ModAPI.IMyIdentity@PlayerId)|_**Obsolete:** Use IdentityId instead._|

