**Assembly:** VRage.Game.dll

```csharp
public struct MySprite: IEquatable<MySprite>
```

## Fields

|Member|Description|
|---|---|
|[Alignment](VRage.Game.GUI.TextPanel.MySprite@Alignment)|Alignment for the text and sprites.|
|[Color](VRage.Game.GUI.TextPanel.MySprite@Color)|Color mask to be used when rendering this layer. If not set, white will be used|
|[Data](VRage.Game.GUI.TextPanel.MySprite@Data)|Data to be rendered, depending on what the layer type is. This can be text or a texture path|
|[FontId](VRage.Game.GUI.TextPanel.MySprite@FontId)|In case we are rendering text, what font to use.|
|[Position](VRage.Game.GUI.TextPanel.MySprite@Position)|Render position for this layer. If not set, it will be placed in the center|
|[RotationOrScale](VRage.Game.GUI.TextPanel.MySprite@RotationOrScale)|Rotation of sprite in radians. Used as scale for text.|
|[Size](VRage.Game.GUI.TextPanel.MySprite@Size)|Render size for this layer. If not set, it will be sized to take up the whole texture|
|[Type](VRage.Game.GUI.TextPanel.MySprite@Type)|Type of the render layer|

## Constructors

|Member|Description|
|---|---|
|[MySprite(SpriteType, string, Vector2?, Vector2?, Color?, string, TextAlignment, float)](VRage.Game.GUI.TextPanel.MySprite@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static CreateClearClipRect()](VRage.Game.GUI.TextPanel.MySprite@CreateClearClipRect)||
|[static CreateClipRect(Rectangle)](VRage.Game.GUI.TextPanel.MySprite@CreateClipRect)||
|[static CreateSprite(string, Vector2, Vector2)](VRage.Game.GUI.TextPanel.MySprite@CreateSprite)||
|[static CreateText(string, string, Color, float, TextAlignment)](VRage.Game.GUI.TextPanel.MySprite@CreateText)||
|[Equals(MySprite)](VRage.Game.GUI.TextPanel.MySprite@Equals)||
|[Equals(object)](VRage.Game.GUI.TextPanel.MySprite@Equals)||
|[GetHashCode()](VRage.Game.GUI.TextPanel.MySprite@GetHashCode)||

**Implements:**  
* [IEquatable<MySprite>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

