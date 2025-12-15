## Summary

```csharp
public virtual List<MySerializedTextPanelData> GetTextPanelsData()
```

Used to get correct TextPanel stored data. v199- using `TextPanels` and v200+ using `TextPanelsNew`. LCD data should be saved into `TextPanelsNew`, but readed from TextPanels if it is not null.

## Returns

[List<MySerializedTextPanelData>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)



