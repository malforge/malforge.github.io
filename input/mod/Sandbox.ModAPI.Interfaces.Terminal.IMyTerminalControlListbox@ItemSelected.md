## Summary

```csharp
public Action<IMyTerminalBlock, List<MyTerminalControlListBoxItem>> ItemSelected { set; }
```

This is triggered when an item is selected. Can contain more than one item if Multiselect is true.

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)&lt;[IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock), [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyTerminalControlListBoxItem](VRage.ModAPI.MyTerminalControlListBoxItem)&gt;&gt;

