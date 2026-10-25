## Summary

```csharp
public DictionaryReader<string, MyWhitelistTarget> GetWhitelist()
```

Gets information about whitelisted classes and methods

## Returns

[DictionaryReader](VRage.Collections.DictionaryReader{K,V})&lt;[string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6), MyWhitelistTarget <sub>prohibited</sub>&gt;

Dictionary reader, where key - name of namespace, type of method, and value - in which context it is allowed

