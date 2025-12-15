**Assembly:** VRage.dll

```csharp
public enum MyResourceStateEnum
```

Enumeration describing Enabled state of multiple objects.

## Fields

|Member|Description|
|---|---|
|Disconnected|Used only for internal use.|
|NoPower|No power|
|Ok|Working fine. Every block has enough power|
|OverloadAdaptible|Some adaptible group does not have enough resources, but everything else still works fine|
|OverloadBlackout|Some non-adaptible group does not have enough resources, so it is without power|

