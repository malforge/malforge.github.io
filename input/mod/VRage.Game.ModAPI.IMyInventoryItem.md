**Assembly:** VRage.Game.dll

```csharp
public interface IMyInventoryItem: IMyInventoryItem
```

Describes item stack in inventory (mod interface)

## Properties

|Member|Description|
|---|---|
|[Amount](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Amount)|Gets or sets amount of items<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|
|[Content](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Content)|Gets or sets content of inventory item. Cast it to [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|
|[ItemId](VRage.Game.ModAPI.Ingame.IMyInventoryItem@ItemId)|Item Id. Used to determine exact stack<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|
|[Scale](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Scale)|Gets or sets scale of Floating object<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|

**Implements:**  
* [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)

**Inheritors:**  
* [MyPhysicalInventoryItem](VRage.Game.Entity.MyPhysicalInventoryItem)

