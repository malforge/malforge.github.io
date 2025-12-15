**Assembly:** VRage.Render.dll

```csharp
public struct MyTextureChange
```

Material slot uses same semantics as texture params in MyMaterialDescriptor: "ColorMetalTexture" "NormalGlossTexture" "AddMapsTexture" "AlphamaskTexture" if MaterialSlot == null: will be treated as "ColorMetalTexture" (please don't mix explicit and implicit slot naming for same object) in dx9 renderer it is used only to change diffuse texture, so MaterialSlot can be null

## Fields

|Member|Description|
|---|---|
|[AlphamaskFileName](VRageRender.Messages.MyTextureChange@AlphamaskFileName)||
|[ColorMetalFileName](VRageRender.Messages.MyTextureChange@ColorMetalFileName)||
|[ExtensionsFileName](VRageRender.Messages.MyTextureChange@ExtensionsFileName)||
|[NormalGlossFileName](VRageRender.Messages.MyTextureChange@NormalGlossFileName)||

## Methods

|Member|Description|
|---|---|
|[IsDefault()](VRageRender.Messages.MyTextureChange@IsDefault)||

