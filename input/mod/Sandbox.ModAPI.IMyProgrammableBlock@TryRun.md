## Summary

```csharp
public bool TryRun(string argument)
```

Attempts to run this programmable block using the given argument. An already running programmable block cannot be run again. This is equivalent to running`block.ApplyAction("Run", argumentsList);`This should be called from an ingame script. Do not use in mods.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

`true`if the action was applied,`false`otherwise

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) argument
