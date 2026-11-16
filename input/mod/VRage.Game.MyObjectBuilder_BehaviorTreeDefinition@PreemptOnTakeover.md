## Summary

```csharp
public bool? PreemptOnTakeover
```

True: a RUNNING branch exits only when the tick ends on a different path. False: legacy, any RUNNING-capable node evaluated off the running path aborts it in place. Must be set explicitly per tree.

## Returns

[bool?](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

