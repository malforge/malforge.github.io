**Assembly:** Sandbox.Game.dll

```csharp
public class MyDecals: IMyDecalHandler
```

## Methods

|Member|Description|
|---|---|
|[static AddDecal(ref MyDecalRenderInfo, List<uint>)](Sandbox.Game.MyDecals@AddDecal)|Add decal raw|
|[static HandleAddDecal(IMyEntity, MyHitInfo, Vector3, MyStringHash, MyStringHash, object, float, MyStringHash, bool, MyDecalFlags, int, List<uint>)](Sandbox.Game.MyDecals@HandleAddDecal)|Adds decal|
|[static RemoveDecal(uint, bool)](Sandbox.Game.MyDecals@RemoveDecal)|Removes decals with specified Id|
|[static UpdateDecals(List<MyDecalPositionUpdate>)](Sandbox.Game.MyDecals@UpdateDecals)|Updates decals position and matrix by id|
|[AddDecal(ref MyDecalRenderInfo, List<uint>)](VRage.Game.ModAPI.Interfaces.IMyDecalHandler@AddDecal)|Adds decal<br /><br />_Inherited from [IMyDecalHandler](VRage.Game.ModAPI.Interfaces.IMyDecalHandler)_|

**Implements:**  
* [IMyDecalHandler](VRage.Game.ModAPI.Interfaces.IMyDecalHandler)

