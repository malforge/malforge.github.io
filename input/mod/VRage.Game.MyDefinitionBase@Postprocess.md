## Summary

```csharp
public virtual void Postprocess()
```

Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.Postprocess is useful if you want to process the definition before the game begins,  
  
but you only want to do it when all the definitions are loaded and merged.

