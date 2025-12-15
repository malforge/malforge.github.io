## Summary

```csharp
public static bool HasSection(string config, string section)
```

Determines if the given configuration contains what looks like the given section. It does not verify that the content is actually in a valid format, just if there's a line starting with [section].

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) config
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) section
