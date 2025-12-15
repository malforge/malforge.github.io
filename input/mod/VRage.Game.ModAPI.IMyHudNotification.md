**Assembly:** VRage.Game.dll

```csharp
public interface IMyHudNotification
```

Describes interface of notification (mods interface)

## Properties

|Member|Description|
|---|---|
|[AliveTime](VRage.Game.ModAPI.IMyHudNotification@AliveTime)|Get or set the time for the notification to be shown, in milliseconds.|
|[Font](VRage.Game.ModAPI.IMyHudNotification@Font)|Get or set the font for this notification. Setting it will immediately update it if the notification is shown.|
|[Text](VRage.Game.ModAPI.IMyHudNotification@Text)|Get or set the notification text. Setting the text will immediately update it if the notification is shown.|

## Methods

|Member|Description|
|---|---|
|[Hide()](VRage.Game.ModAPI.IMyHudNotification@Hide)|Hides the notification on the HUD even if it was supposed to show for longer.|
|[ResetAliveTime()](VRage.Game.ModAPI.IMyHudNotification@ResetAliveTime)|Reset the alive time for the text. This is called when setting AliveTime as well.|
|[Show()](VRage.Game.ModAPI.IMyHudNotification@Show)|Shows the notification on the HUD.|

