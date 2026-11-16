## Summary

```csharp
public static bool DX12MeasureMaterialBinds
```

Measurement scaffold for the bindless-material plan: splits per-draw material SRV binds by binding pipeline and by merge-instancing, tracks the distinct material descriptors a session needs, and times the ring staging. See`MyMaterialBindStats`. Costs a timestamp pair per staged block plus a hash insert per material descriptor, so the timing it reports is very slightly inflated by its own measurement — turn it off before quoting absolute frame times. Temporary; remove with the scaffold.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

