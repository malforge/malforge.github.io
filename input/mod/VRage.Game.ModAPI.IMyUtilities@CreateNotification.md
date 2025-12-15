## Summary

```csharp
public IMyHudNotification CreateNotification(string message, int disappearTimeMs, string font)
```

Create a notification object. The object needs to have Show() called on it to be shown. On top of that you can dynamically change the text, font and adjust the time to live.

## Returns

[IMyHudNotification](VRage.Game.ModAPI.IMyHudNotification)

The notification object.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) message
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) disappearTimeMs
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) font
