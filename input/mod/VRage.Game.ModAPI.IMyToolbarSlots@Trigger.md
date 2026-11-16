## Summary

```csharp
public bool Trigger(int index)
```

Runs the item in a slot, as a player pressing it would. A block toolbar is owned by the server, so this runs there and refuses anywhere else; a mod gets itself to the server by sending its own message and calls this from there. What the item does replicates as usual.  
  
An item that is not currently available does not run: a block action needs its target to share a grid group with the block owning the toolbar.  
  
A slot holding a definition rather than an action - a block to build, a tool - selects it for whoever is at the keyboard. That is the expected thing in single player and nothing useful on a dedicated server, where nobody is.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True when the item ran. False when this is not the server, when the slot is empty or out of range, or when these slots belong to a character toolbar, whose items are for the player at the keyboard to select rather than for a mod to fire.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
