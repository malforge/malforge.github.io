## Summary

```csharp
public void InvokeLater(Action action, string debugName)
```

Schedule a callback to be invoked in the update thread at a later time.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) debugName
## Remarks

This callback will be invoked as soon as possible (possibly even on the same frame).

