## Summary

```csharp
public void SearchActionsOfName(string name, Type blockType, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect)
```

Gets available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type and name

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type?view=netframework-4.6) blockType
* [List<ITerminalAction>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) resultList
* [Func<ITerminalAction, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) collect
