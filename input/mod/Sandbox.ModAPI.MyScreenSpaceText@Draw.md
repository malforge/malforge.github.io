## Summary

```csharp
public static void Draw(string font, string text, Vector2 normalizedPosition, float scale, Color color, MyGuiDrawAlignEnum align, float maxWidth, MyScreenSpaceLayer layer)
```

Draws a single-colour line or block of text. There is no markup: to mix colours, draw one call per colour run and advance the position using [Measure(string, string, float)](Sandbox.ModAPI.MyScreenSpaceText@Measure) .

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) font
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) text
* [Vector2](VRageMath.Vector2) normalizedPosition
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) scale
* [Color](VRageMath.Color) color
* [MyGuiDrawAlignEnum](VRage.Utils.MyGuiDrawAlignEnum) align
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) maxWidth
* [MyScreenSpaceLayer](Sandbox.ModAPI.MyScreenSpaceLayer) layer
