## Summary

```csharp
public bool TryGetItem(int index, out MyToolbarItemInfo info)
```

Reads what a slot holds. Copies out; nothing in the result tracks later edits.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True when the slot holds something, false when it is empty or the index is out of range.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
* [MyToolbarItemInfo](VRage.Game.ModAPI.MyToolbarItemInfo) info
