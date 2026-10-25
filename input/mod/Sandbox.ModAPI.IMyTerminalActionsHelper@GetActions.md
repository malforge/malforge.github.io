## Summary

```csharp
public void GetActions(Type blockType, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect)
```

Gets available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type

## Parameters

* [Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type?view=netframework-4.6) blockType
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)&gt; resultList
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; collect
