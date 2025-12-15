**Assembly:** VRage.Game.dll

```csharp
public enum MyAutorotateMode
```

## Fields

|Member|Description|
|---|---|
|FirstDirection|When block has mountpoint on at least one side, it will autorotate so that this side is touching the surface. Otherwise, full range of rotations is allowed.|
|OneDirection|When block has mount points only on one side, it will autorotate so that side is touching the surface. Otherwise, full range of rotations is allowed.|
|OppositeDirections|When block has mount points only on two sides and those sides are opposite each other (eg. Top and Bottom), it will autorotate so that one of these sides is touching the surface. Otherwise, full range of rotations is allowed.|

