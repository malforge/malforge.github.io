**Assembly:** VRage.Game.dll

```csharp
public enum GridLinkTypeEnum
```

Defines different link types for grid groups.

## Fields

|Member|Description|
|---|---|
|Electrical|Connections by rotor, piston, suspension and connectors if they transfer energy.|
|Logical|Terminal connections. i.e. rotors, pistons, wheels. Includes Mechanical connections.|
|Mechanical|Connections by rotor, piston, suspension.|
|NoContactDamage|Connections which lock physics, but do not connect terminals. Landing gear only.|
|Physical|Connections which lock physics. i.e. connectors. Includes Logical and Mechanical connections.|

