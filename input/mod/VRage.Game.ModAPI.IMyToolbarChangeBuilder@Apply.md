## Summary

```csharp
public bool Apply()
```

Applies the batch on the machine that owns these slots, and refuses anywhere else. A block toolbar is owned by the server, which applies the change and tells every client about it in a single message. A character toolbar is owned by its own player's machine, which applies it and lets it reach the session's saved copy from there.  
  
So a mod gets itself to the machine that owns the toolbar, by sending its own message, and calls this there. A slot the toolbar cannot hold is skipped and the rest still land, so a batch can apply in part. The builder is not consumed: keep it and apply it again to repeat the same batch.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True when the batch was applied. False when this machine does not own these slots, when the batch was empty, when any call addressed a slot that does not exist or named a definition that is not loaded, or when these slots belong to a toolbar the mod API cannot write.

