## Summary

```csharp
public void SearchBlocksOfName(string name, List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect)
```

Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [List<IMyTerminalBlock>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) blocks
* [Func<IMyTerminalBlock, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) collect
