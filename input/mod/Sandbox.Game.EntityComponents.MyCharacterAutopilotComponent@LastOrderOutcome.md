## Summary

```csharp
public MyAutopilotOrderOutcome LastOrderOutcome { get; }
```

Terminal result of the most recent accepted order. None while an order is still in progress; a rejected order call (no server, no definition, no jetpack) keeps the previous value. Disambiguates the otherwise identical Holding states: an arrival versus a degraded Land/Follow.

## Returns

[MyAutopilotOrderOutcome](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent+MyAutopilotOrderOutcome)

