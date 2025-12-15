**Assembly:** VRage.Game.dll

```csharp
public interface IMyOxygenProviderSystem
```

ModAPI interface allowing to get information about oxygen level and giving ability to register [IMyOxygenProvider](VRage.Game.ModAPI.IMyOxygenProvider) 

## Methods

|Member|Description|
|---|---|
|[AddOxygenGenerator(IMyOxygenProvider)](VRage.Game.ModAPI.IMyOxygenProviderSystem@AddOxygenGenerator)|Registers oxygen provider|
|[GetOxygenInPoint(Vector3D)](VRage.Game.ModAPI.IMyOxygenProviderSystem@GetOxygenInPoint)|Gets oxygen level in point|
|[RemoveOxygenGenerator(IMyOxygenProvider)](VRage.Game.ModAPI.IMyOxygenProviderSystem@RemoveOxygenGenerator)|Unregisters oxygen provider|

