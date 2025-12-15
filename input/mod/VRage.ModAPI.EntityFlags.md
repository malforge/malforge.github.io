**Assembly:** VRage.Game.dll

```csharp
public enum EntityFlags
```

Entity flags.

## Fields

|Member|Description|
|---|---|
|Default||
|DrawOutsideViewDistance|Flags would be delivered to render component. `DrawOutsideViewDistance`<sub>prohibited</sub> |
|FastCastShadowResolve|Flags would be delivered to render component. `FastCastShadowResolve`<sub>prohibited</sub> |
|InvalidateOnMove|If object is moved, invalidate its renderobjects (update render)|
|IsGamePrunningStructureObject|Can be added, removed, or updated in|
|IsNotGamePrunningStructureObject|Do not use in prunning, even though it is a root entity|
|Near|Specifies whether entity is "near", near entities are cockpit and weapons, these entities are rendered in special way|
|NeedsDraw|Draw method of this entity will be called when suitable. [NeedsDraw](VRage.Game.Components.MyRenderComponentBase@NeedsDraw) |
|NeedsDrawFromParent|Draw method of this entity will be called when suitable and only from parent|
|NeedsResolveCastShadow|Flags would be delivered to render component. `NeedsResolveCastShadow`<sub>prohibited</sub> |
|NeedsSimulate|Entity has special simulation update. [SIMULATE](VRage.ModAPI.MyEntityUpdateEnum@SIMULATE) |
|NeedsUpdate|On this entity and its children will be called UpdateBeforeSimulation and UpdateAfterSimulation each frame|
|NeedsUpdate10|Entity updated each 10th frame|
|NeedsUpdate100|Entity updated each 100th frame|
|NeedsUpdateAfter|On this entity and its children will be called UpdateAfterSimulation each frame|
|NeedsUpdateBeforeNextFrame|Entity updated once before first frame.|
|NeedsWorldMatrix|If child, its world matrix must be always updated|
|None|No flags|
|Save|Specifies whether save entity when saving sector or not|
|ShadowBoxLod|Draw LOD shadow as box|
|SkipIfTooSmall|Flags would be delivered to render component. `SkipIfTooSmall`<sub>prohibited</sub> |
|Sync|Synchronize object during multiplayer|
|Transparent|Render the entity using dithering to simulate transparency|
|UpdateRender|Entity call [UpdateRenderObject(bool, bool)](VRage.Game.Components.MyRenderComponentBase@UpdateRenderObject) on OnAddedToScene|
|Visible|Specifies whether draw this entity or not.|

