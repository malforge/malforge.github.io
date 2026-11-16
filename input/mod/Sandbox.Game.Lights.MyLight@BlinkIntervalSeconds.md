## Summary

```csharp
public float BlinkIntervalSeconds { get; set; }
```

Seconds between the starts of this light's blinks, 0 for a light that does not blink. The blink is applied by whoever drives [LightOn](Sandbox.Game.Lights.MyLight@LightOn) ; this only tells the renderer that those flips are a blink and how long they last, so a shadow it holds for the light can outlive an off phase.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

