## Summary

```csharp
public void CreateFaction(long founderId, string tag, string name, string desc, string privateInfo)
```

Creates new faction with faction type. Obsolete. Use [CreateFactionNew(long, string, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateFactionNew) 

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) founderId
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) tag
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) desc
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) privateInfo
## Remarks

You should use [CreateFaction(long, string, string, string, string, MyFactionTypes)](VRage.Game.ModAPI.IMyFactionCollection@CreateFaction) if you want to create a faction with different type ().

## Summary

```csharp
public void CreateFaction(long founderId, string tag, string name, string desc, string privateInfo, MyFactionTypes type)
```

Creates new faction Obsolete. Use [CreateFactionNew(long, string, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateFactionNew) 

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) founderId
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) tag
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) desc
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) privateInfo
* [MyFactionTypes](VRage.Game.MyFactionTypes) type
