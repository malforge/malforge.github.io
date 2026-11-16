## Summary

```csharp
public static void GetActionParameterDefinitions(this IMyTerminalBlock block, string actionId, List<TypeCode> output)
```

Clearsoutputand fills it with the type of each argument an action takes, in the order it expects them. Empty for the great majority of actions, which take none. Build the arguments themselves with TerminalActionParameter.Get.  
  
Unlike [GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetActionWithName) this finds actions whatever toolbar they are meant for, so it answers for actions that lookup cannot return.

## Parameters

* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock) block
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) actionId
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[TypeCode](https://docs.microsoft.com/en-us/dotnet/api/System.TypeCode?view=netframework-4.6)&gt; output
