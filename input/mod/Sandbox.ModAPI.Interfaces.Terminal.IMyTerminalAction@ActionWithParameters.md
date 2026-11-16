## Summary

```csharp
public Action<IMyTerminalBlock, ListReader<TerminalActionParameter>> ActionWithParameters { get; set; }
```

What the action does, given the arguments it was run with. Set this rather than [Action](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@Action) when the action takes any; setting either one replaces the other.

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)&lt;[IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock), [ListReader](VRage.Collections.ListReader{T})&lt;[TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter)&gt;&gt;

