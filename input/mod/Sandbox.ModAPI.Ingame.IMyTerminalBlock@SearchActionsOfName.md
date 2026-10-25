## Summary

```csharp
public void SearchActionsOfName(string name, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect)
```

Get all terminal actions available for block. NOTE: First called `  
  
` and then `  
  
` check

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)&gt; resultList
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; collect
