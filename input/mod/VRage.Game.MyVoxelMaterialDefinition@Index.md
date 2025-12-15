## Summary

```csharp
public byte Index { get; set; }
```

Value generated at runtime to ensure correctness. Do not serialize or deserialize. This is what the old cast to int used to result into, but now numbers depend on order in XML file. TODO Serialize to XML and ensure upon loading that these values are starting from 0 and continuous.

## Returns

[byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte?view=netframework-4.6)

