## Summary

```csharp
public void EndUpdate(Byte[] pixels)
```

Hands the filled buffer to the renderer, which replaces the whole image with it and rebuilds the mip chain. The buffer belongs to the renderer from here on — write to it again and you will see a torn image.

## Parameters

* [byte[]](https://docs.microsoft.com/en-us/dotnet/api/System.Byte?view=netframework-4.6) pixels
