## Summary

```csharp
public bool TryGetPlanetElevation(MyPlanetElevation detail, out double elevation)
```

Attempts to get the elevation of the ship in relation to the nearest planet. This method is only available when a ship is within the gravity well of a planet.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if cockpit is in planet gravity

## Parameters

* [MyPlanetElevation](Sandbox.ModAPI.Ingame.MyPlanetElevation) detail
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) elevation
