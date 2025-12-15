## Summary

```csharp
public bool WriteText(string value, bool append)
```

Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if text was added, or replaced. False if somebody was looking at lcd

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) value
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) append
## Summary

```csharp
public bool WriteText(StringBuilder value, bool append)
```

Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if text was added, or replaced. False if somebody was looking at lcd

## Parameters

* [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder?view=netframework-4.6) value
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) append
