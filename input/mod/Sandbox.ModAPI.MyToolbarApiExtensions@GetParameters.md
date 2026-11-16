## Summary

```csharp
public static void GetParameters(this IMyToolbarSlots slots, int index, List<TerminalActionParameter> output)
```

Clearsoutputand fills it with the arguments the slot's action was given, in the order the action declares them. Empty for a slot that holds no action or whose action takes none, which is most of them.

## Parameters

* [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots) slots
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter)&gt; output
