## Summary

```csharp
public CustomActionGetDelegate event CustomActionGetter
```

This event allows you to modify the list of actions available when a user wants to select an action for a block in the toolbar. Modifying the list in this event modifies the list displayed to the user so that you can customize it in specific situations (like blocks with different subtypes, or even on specific blocks by entityId)

## Returns

[CustomActionGetDelegate](Sandbox.ModAPI.CustomActionGetDelegate)

