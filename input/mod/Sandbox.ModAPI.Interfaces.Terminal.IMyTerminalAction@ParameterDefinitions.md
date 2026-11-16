## Summary

```csharp
public List<TerminalActionParameter> ParameterDefinitions { get; }
```

Arguments this action takes, in the order it expects them. Add one entry per argument with TerminalActionParameter.Get; the value fixes the argument's type, and is what the action is given when it is run with none supplied.

## Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter)&gt;

