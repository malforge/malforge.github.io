## Summary

```csharp
public void SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange> value)
```

Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp  
MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);  
  
```

## Parameters

* [Dictionary<MyStringId, MyTextureChange>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netframework-4.6) value
## Summary

```csharp
public void SetTextureChangesForSubparts(Dictionary<string, MyTextureChange> value)
```

This calling is obsolete, use another version.

## Parameters

* [Dictionary<string, MyTextureChange>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netframework-4.6) value
