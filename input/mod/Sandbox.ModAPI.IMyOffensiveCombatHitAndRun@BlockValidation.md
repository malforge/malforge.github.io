## Summary

```csharp
public Func<IMyTerminalBlock, bool> BlockValidation { get; set; }
```

Gets or sets function that is called when block caches all available weapons, and called on server to validate, that user selected weapon is correct Used for adding custom weapons. By default used reference to Keen default function Must not be null. You need override it on server and client

## Returns

[Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt;

