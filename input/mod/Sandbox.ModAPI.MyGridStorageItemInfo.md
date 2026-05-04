**Assembly:** Sandbox.Common.dll

```csharp
public class MyGridStorageItemInfo
```

Data transfer object which aggregates properties of a grid in the context of grid storage system (Service Terminal). Intended for presentation and validation purposes.

## Fields

|Member|Description|
|---|---|
|[BlockCount](Sandbox.ModAPI.MyGridStorageItemInfo@BlockCount)|Total blocks count for this storage item|
|[BlockLimits](Sandbox.ModAPI.MyGridStorageItemInfo@BlockLimits)|Block limits potentially occupied by this storage item|
|[DisplayName](Sandbox.ModAPI.MyGridStorageItemInfo@DisplayName)|Name of the stored item or the name of the root active grid|
|[EntityId](Sandbox.ModAPI.MyGridStorageItemInfo@EntityId)|Entity id of a nearby grid which can be stored|
|[GridType](Sandbox.ModAPI.MyGridStorageItemInfo@GridType)|Large or small grid|
|[Id](Sandbox.ModAPI.MyGridStorageItemInfo@Id)|Identity of an item in the grid storage|
|[OwnerId](Sandbox.ModAPI.MyGridStorageItemInfo@OwnerId)|Identity of the original owner (for stored grids) or major owner (for active grids)|
|[OwnershipKind](Sandbox.ModAPI.MyGridStorageItemInfo@OwnershipKind)|Sharing settings|
|[PcuCount](Sandbox.ModAPI.MyGridStorageItemInfo@PcuCount)|PCU count of the whole grid group|

## Constructors

|Member|Description|
|---|---|
|[MyGridStorageItemInfo()](Sandbox.ModAPI.MyGridStorageItemInfo@.ctor)||

