## Summary

```csharp
public IMyToolbar GetToolbar(int toolbarIndex)
```

Gets one of this entity's toolbars by index. Index 0 is always the primary toolbar: the one a player drives directly where there is one, otherwise the toolbar the block triggers itself. Use this to enumerate every toolbar; to reach a specific one where there are several, prefer the named accessors on the block's own interface.

## Returns

[IMyToolbar](VRage.Game.ModAPI.IMyToolbar)

The toolbar, or null when the index is out of range.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) toolbarIndex
