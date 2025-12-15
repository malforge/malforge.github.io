## Summary

```csharp
public static void ApplyActionOnPersistentBillboards(Action<MyBillboard> action)
```

Used to update billboards. It iterates over each MyBillBoard. Use [ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) if you need iterate over specific billboards.

## Parameters

* [Action<MyBillboard>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) action
## Summary

```csharp
public static void ApplyActionOnPersistentBillboards(Action action)
```

Used to update billboards. You can change any values of MyBillboard inside of this action call. Used to iterate over your own set of Billboards, instead of all, that currently drawing.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
