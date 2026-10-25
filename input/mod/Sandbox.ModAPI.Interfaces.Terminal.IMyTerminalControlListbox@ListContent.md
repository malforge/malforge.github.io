## Summary

```csharp
public Action<IMyTerminalBlock, List<MyTerminalControlListBoxItem>, List<MyTerminalControlListBoxItem>> ListContent { set; }
```

This is triggered when you need to populate the list with list items. The first list is the items in the list box, and the second list is the selected items in the list.

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3?view=netframework-4.6)&lt;[IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock), [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyTerminalControlListBoxItem](VRage.ModAPI.MyTerminalControlListBoxItem)&gt;, [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyTerminalControlListBoxItem](VRage.ModAPI.MyTerminalControlListBoxItem)&gt;&gt;

