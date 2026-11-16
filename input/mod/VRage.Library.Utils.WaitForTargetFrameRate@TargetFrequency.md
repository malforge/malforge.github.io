## Summary

```csharp
public float TargetFrequency { get; set; }
```

Frames per second this waiter paces to. Settable at runtime; the accumulated target is rebased on the current tick, without which the first frame after a change is stretched or skipped by the ratio of the old period to the new one.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

