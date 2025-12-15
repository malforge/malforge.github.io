## Summary

```csharp
public IMyStoreItem CreateStoreItem(MyDefinitionId itemId, int amount, int pricePerUnit, StoreItemTypes storeItemType)
```

Creates a store item that allows more control over how the item is setup. This method is suitable for PhysicalItem types.

## Returns

[IMyStoreItem](VRage.Game.ModAPI.IMyStoreItem)

Result of the creation of the store item.

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) itemId
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) amount
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) pricePerUnit
* [StoreItemTypes](VRage.Game.ObjectBuilders.Definitions.StoreItemTypes) storeItemType
## Summary

```csharp
public IMyStoreItem CreateStoreItem(int amount, int pricePerUnit, StoreItemTypes storeItemType, ItemTypes itemType)
```

Creates a store item that allows more control over how the item is setup. This method is suitable for Hydrogen and Oxygen types.

## Returns

[IMyStoreItem](VRage.Game.ModAPI.IMyStoreItem)

Result of the creation of the store item.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) amount
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) pricePerUnit
* [StoreItemTypes](VRage.Game.ObjectBuilders.Definitions.StoreItemTypes) storeItemType
* [ItemTypes](VRage.Game.ObjectBuilders.Definitions.ItemTypes) itemType
## Summary

```csharp
public IMyStoreItem CreateStoreItem(string prefabName, int amount, int pricePerUnit, int totalPcu)
```

Creates a store item that sells a Prefab / Grid.

## Returns

[IMyStoreItem](VRage.Game.ModAPI.IMyStoreItem)

Result of the creation of the store item.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) prefabName
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) amount
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) pricePerUnit
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) totalPcu
## Summary

```csharp
public IMyStoreItem CreateStoreItem(MyObjectBuilder_StoreItem builder)
```

Creates a store item that allows more control over how the item is setup by using an object builder to initialize the item.

## Returns

[IMyStoreItem](VRage.Game.ModAPI.IMyStoreItem)

Result of the creation of the store item.

## Parameters

* [MyObjectBuilder_StoreItem](VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_StoreItem) builder
