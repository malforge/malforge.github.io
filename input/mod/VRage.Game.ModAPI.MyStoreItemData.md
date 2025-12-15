**Assembly:** VRage.Game.dll

```csharp
public struct MyStoreItemData
```

Implements Store Item Data

## Properties

|Member|Description|
|---|---|
|[Amount](VRage.Game.ModAPI.MyStoreItemData@Amount)|Gets amount for buy/sell|
|[ItemId](VRage.Game.ModAPI.MyStoreItemData@ItemId)|Gets definition id of the item|
|[OnCancel](VRage.Game.ModAPI.MyStoreItemData@OnCancel)|When owner of store block cancels order/offer regarding this item|
|[OnTransaction](VRage.Game.ModAPI.MyStoreItemData@OnTransaction)|When player makes an transaction regarding this item int - amount sold int - amount remaining int - price of transaction long - owner of block long - buyer/seller|
|[PricePerUnit](VRage.Game.ModAPI.MyStoreItemData@PricePerUnit)|Gets price per unit|

## Constructors

|Member|Description|
|---|---|
|[MyStoreItemData(SerializableDefinitionId, int, int, Action<int, int, long, long, long>, Action)](VRage.Game.ModAPI.MyStoreItemData@.ctor)||

