## Summary

```csharp
public void SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange> value)
```

Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp  
MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);  
  
```

## Parameters

* [Dictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netframework-4.6)&lt;[MyStringId](VRage.Utils.MyStringId), [MyTextureChange](VRageRender.Messages.MyTextureChange)&gt; value
## Summary

```csharp
public void SetTextureChangesForSubparts(Dictionary<string, MyTextureChange> value)
```

This calling is obsolete, use another version.

## Parameters

* [Dictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netframework-4.6)&lt;[string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6), [MyTextureChange](VRageRender.Messages.MyTextureChange)&gt; value
