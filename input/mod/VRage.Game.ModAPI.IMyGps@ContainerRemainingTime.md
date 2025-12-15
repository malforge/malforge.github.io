## Summary

```csharp
public string ContainerRemainingTime { get; set; }
```

Gets or sets gps text that would be displayed on HUD

## Returns

[string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6)

## Remarks

Set method doesn't synchronize data over network. Use [ModifyGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@ModifyGps) , to update data

