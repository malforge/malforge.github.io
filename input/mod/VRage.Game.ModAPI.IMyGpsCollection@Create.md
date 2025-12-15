## Summary

```csharp
public IMyGps Create(string name, string description, Vector3D coords, bool showOnHud, bool temporary)
```

Creates a GPS entry object. Does not automatically add it, you need to use AddGps() or AddLocalGps().

## Returns

[IMyGps](VRage.Game.ModAPI.IMyGps)

GPS object

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) description
* [Vector3D](VRageMath.Vector3D) coords
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) showOnHud
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) temporary
