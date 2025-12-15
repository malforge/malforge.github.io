## Summary

```csharp
public TimeSpan? DiscardAt { get; set; }
```

If it's null then the GPS is confirmed (does not expire automatically). Otherwise, time at which we should drop it from the list, relative to ElapsedPlayTime

## Returns

[TimeSpan?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

## Remarks

Set method doesn't synchronize data over network. Use [ModifyGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@ModifyGps) , to update data

