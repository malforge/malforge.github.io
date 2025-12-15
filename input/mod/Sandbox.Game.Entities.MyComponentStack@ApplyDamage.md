## Summary

```csharp
public void ApplyDamage(float damage, MyConstructionStockpile outputStockpile)
```

Applies damage to the component stack. The method works almost the same as dismounting, it just leaves the build level at the original value and also the parts that are put into the outputStockpile are damaged.

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) damage
* [MyConstructionStockpile](Sandbox.Game.Entities.MyConstructionStockpile) outputStockpile
