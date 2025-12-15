## Summary

```csharp
public virtual void SetContainer(IMyComponentContainer container)
```

Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.

## Parameters

* [IMyComponentContainer](VRage.Game.Components.Interfaces.IMyComponentContainer) container
