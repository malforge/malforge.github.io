## Summary

```csharp
public bool CanTransferItemTo(IMyInventory otherInventory, MyItemType itemType)
```

Determines if there is working conveyor connection for item of give type to be transferred to other inventory.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if there is working conveyor connection between inventories so that item of give type can by transferred, false otherwise

## Parameters

* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory) otherInventory
* [MyItemType](VRage.Game.ModAPI.Ingame.MyItemType) itemType
