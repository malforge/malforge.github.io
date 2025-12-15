**Assembly:** VRage.Game.dll

```csharp
public interface IMyInventoryItem
```

Describes item stack in inventory (program block interface)

## Properties

|Member|Description|
|---|---|
|[Amount](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Amount)|Gets or sets amount of items|
|[Content](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Content)|Gets or sets content of inventory item. Cast it to [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject) |
|[ItemId](VRage.Game.ModAPI.Ingame.IMyInventoryItem@ItemId)|Item Id. Used to determine exact stack|
|[Scale](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Scale)|Gets or sets scale of Floating object|

**Inheritors:**  
* [IMyInventoryItem](VRage.Game.ModAPI.IMyInventoryItem)  
* [MyPhysicalInventoryItem](VRage.Game.Entity.MyPhysicalInventoryItem)

