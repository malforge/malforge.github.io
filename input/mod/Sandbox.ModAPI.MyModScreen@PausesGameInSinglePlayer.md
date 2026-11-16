## Summary

```csharp
public bool PausesGameInSinglePlayer { get; set; }
```

Pauses a single-player game while the screen is open, as the main menu does. Ignored in multiplayer. Read when the screen opens, so set it before [Open()](Sandbox.ModAPI.MyModScreen@Open) .

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

