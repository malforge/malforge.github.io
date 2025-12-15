## Summary

```csharp
public Action<IMyTerminalBlock, StringBuilder> Writer { get; set; }
```

This is triggered when a slider value is modified. Appending to the string builder allows you to modify the text that is displayed along side the slider when it updates.

## Returns

[Action<IMyTerminalBlock, StringBuilder>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)

