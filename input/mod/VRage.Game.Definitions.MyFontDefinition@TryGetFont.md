## Summary

```csharp
public static bool TryGetFont(MyStringHash fontId, out MyFont font)
```

Safe counterpart of [GetFont(MyStringHash)](VRage.Game.Definitions.MyFontDefinition@GetFont) , which throws on an unregistered id.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True when the font is registered.

## Parameters

* [MyStringHash](VRage.Utils.MyStringHash) fontId
* MyFont <sub>prohibited</sub> font
