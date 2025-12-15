## Summary

```csharp
public static void AddBillboards(IEnumerable<MyBillboard> billboards, bool isPersistent)
```

Adds billboards to render. Remember, that added persistent billboards you can change ONLY with [ApplyActionOnPersistentBillboards(Action<MyBillboard>)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) and [ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) methods

## Parameters

* [IEnumerable<MyBillboard>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) billboards
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isPersistent
