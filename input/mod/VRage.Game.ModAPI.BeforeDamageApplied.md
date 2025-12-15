**Assembly:** VRage.Game.dll

```csharp
public sealed class BeforeDamageApplied: MulticastDelegate, ICloneable, ISerializable
```

This delegate is used to handle damage before it's applied to an object. This returns a modified damage that is used in DoDamage. Return damage if no change.

## Constructors

|Member|Description|
|---|---|
|[BeforeDamageApplied(object, IntPtr)](VRage.Game.ModAPI.BeforeDamageApplied@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(object, ref MyDamageInformation, AsyncCallback, object)](VRage.Game.ModAPI.BeforeDamageApplied@BeginInvoke)||
|[EndInvoke(ref MyDamageInformation, IAsyncResult)](VRage.Game.ModAPI.BeforeDamageApplied@EndInvoke)||
|[Invoke(object, ref MyDamageInformation)](VRage.Game.ModAPI.BeforeDamageApplied@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

