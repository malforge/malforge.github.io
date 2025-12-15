## Summary

```csharp
public static void AddBillboard(MyBillboard billboard, bool isPersistent)
```

Adds billboard to render. Remember, that added persistent billboard you can change ONLY with [ApplyActionOnPersistentBillboards(Action<MyBillboard>)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) and [ApplyActionOnPersistentBillboards(Action)](VRage.Game.MyTransparentGeometry@ApplyActionOnPersistentBillboards) methods FOR MODDERS: If you have more than 100 billboards to remove you should use another [AddBillboards(IEnumerable<MyBillboard>, bool)](VRage.Game.MyTransparentGeometry@AddBillboards) function

## Parameters

* [MyBillboard](VRageRender.MyBillboard) billboard
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isPersistent
