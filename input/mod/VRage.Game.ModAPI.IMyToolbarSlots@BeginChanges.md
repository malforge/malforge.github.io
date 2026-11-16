## Summary

```csharp
public IMyToolbarChangeBuilder BeginChanges()
```

Starts a batch of slot assignments. Chain calls onto the result and finish with [Apply()](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Apply) , which applies the lot together and, for a block toolbar, sends it to clients as one message. Later calls win where two address the same slot.

## Returns

[IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder)

A new builder writing to these slots.

