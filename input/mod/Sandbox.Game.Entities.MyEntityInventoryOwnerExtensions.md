**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyEntityInventoryOwnerExtensions
```

This class simplifies backward compatibility to IMyInventoryOwner in the code Instead checking Entity type, you need to check now if the Entity has Inventory

## Methods

|Member|Description|
|---|---|
|[static InventoryOwnerType(this MyEntity)](Sandbox.Game.Entities.MyEntityInventoryOwnerExtensions@InventoryOwnerType)|_**Obsolete:** IMyInventoryOwner interface and MyInventoryOwnerTypeEnum enum is obsolete. Use type checking and inventory methods on MyEntity or MyInventory. Inventories will have this attribute as member._|

