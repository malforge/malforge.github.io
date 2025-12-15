## Summary

```csharp
public bool IsFunctional { get; }
```

Component stack is functional when critical part is not destroyed (integrity > 0). IMPORTANT: When you change the logic beyond this property, don't forget to call CheckFunctionalState every time the functional state could have been changed! (Also, remove calls to CheckFunctionalState where no longer needed)

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

