**Assembly:** VRage.Game.dll

```csharp
public struct ModAPIMass
```

ModAPI struct, that is available for modders. Copy of `HkMassProperties`<sub>prohibited</sub> . Created with IMyPhysics.CreateMassCombined, IMyPhysics.CreateMassForBox, IMyPhysics.CreateMassForCapsule, IMyPhysics.CreateMassForCylinder, IMyPhysics.CreateMassForSphere.

## Fields

|Member|Description|
|---|---|
|[CenterOfMass](VRage.ModAPI.ModAPIMass@CenterOfMass)|Center of mass for physical shape (CoM)|
|[InertiaTensor](VRage.ModAPI.ModAPIMass@InertiaTensor)|Intertia tensor for physical shape|
|[Mass](VRage.ModAPI.ModAPIMass@Mass)|Mass of physical shape|
|[Volume](VRage.ModAPI.ModAPIMass@Volume)|Volume of physical shape|

## Constructors

|Member|Description|
|---|---|
|[ModAPIMass(float, float, Vector3, Matrix)](VRage.ModAPI.ModAPIMass@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static FromHkMass(HkMassProperties)](VRage.ModAPI.ModAPIMass@FromHkMass)||

