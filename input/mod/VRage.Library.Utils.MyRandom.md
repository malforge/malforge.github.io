**Assembly:** VRage.Library.dll

```csharp
public class MyRandom
```

Original C# implementation which allows settings the seed.

## Properties

|Member|Description|
|---|---|
|[static Instance](VRage.Library.Utils.MyRandom@Instance)||

## Constructors

|Member|Description|
|---|---|
|[MyRandom()](VRage.Library.Utils.MyRandom@.ctor)||
|[MyRandom(int)](VRage.Library.Utils.MyRandom@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CreateRandomSeed()](VRage.Library.Utils.MyRandom@CreateRandomSeed)||
|[GetRandomFloat(float, float)](VRage.Library.Utils.MyRandom@GetRandomFloat)||
|[GetRandomSign()](VRage.Library.Utils.MyRandom@GetRandomSign)||
|[GetState(out State)](VRage.Library.Utils.MyRandom@GetState)||
|[Next()](VRage.Library.Utils.MyRandom@Next)||
|[Next(int)](VRage.Library.Utils.MyRandom@Next)||
|[Next(int, int)](VRage.Library.Utils.MyRandom@Next)||
|[NextBytes(Byte[])](VRage.Library.Utils.MyRandom@NextBytes)||
|[NextDouble()](VRage.Library.Utils.MyRandom@NextDouble)||
|[NextFloat()](VRage.Library.Utils.MyRandom@NextFloat)||
|[NextLong()](VRage.Library.Utils.MyRandom@NextLong)||
|[PushSeed(int)](VRage.Library.Utils.MyRandom@PushSeed)||
|[SetSeed(int)](VRage.Library.Utils.MyRandom@SetSeed)|Sets new seed, only use this method when you have separate instance of MyRandom. Setting seed for RNG used for EntityId without reverting to previous state is dangerous. Use PushSeed for EntityId random generator.|
|[SetState(ref State)](VRage.Library.Utils.MyRandom@SetState)||

