## Summary

```csharp
public bool KeepInputFuncsOnRemove
```

Set by owners that move this sink between entities (e.g. thrust): keeps RequiredInputFunc set even when the current host entity closes, because the sink lives on and Update() would NRE on a null func. Other sinks clear their funcs on teardown to break the func -> entity reference (see ClearInputFuncs).

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

