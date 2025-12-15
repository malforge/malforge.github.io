## Summary

```csharp
public CustomControlGetDelegate event CustomControlGetter
```

This event allows you to modify the list of controls that the game displays when a user selects a block. Each time terminal controls are enumerated for a block, this delegate is called, which allows you to modify the control list directly, and remove/add as you see fit before the controls are displayed. This is to allow fine grain control of the controls being displayed, so you can display only controls you want to in specific situations (like blocks with different subtypes, or even on specific blocks by entityId)

## Returns

[CustomControlGetDelegate](Sandbox.ModAPI.CustomControlGetDelegate)

