The Minifier is a powerful tool designed to shrink large scripts, making them fit within the limitations of the Space Engineers programmable block. However, sometimes you need to ensure certain parts of your code **don’t get minified**. That’s where `mdk preserve` regions come into play.

## Preventing Minification with Preserve Regions

You can mark sections of your code to be preserved by enclosing them in a `#region mdk preserve` block. For example:

```csharp
class MinifyMe
{
    public void DoSomething() 
    {
        // This class and method will be minified.
    }
}

#region mdk preserve
public enum PilotModes
{
    Manual,
    Auto,
    Assist
}

const string ControlSeat = "Flight Seat Alpha";
#endregion
```

All types and constants within a `mdk preserve` region will **not** be altered by the Minifier. This is especially useful for:
- Enums or constants needed by external tools.
- Sections of code where you require exact naming or formatting.

---

> [!WARNING]
> **Keep It Tidy:** Always ensure that your `#region mdk preserve` blocks are properly contained **within a single logical scope** (e.g., inside a class, or method. If a region starts in one scope (like a class or a method) and ends in another, it can cause unexpected results and may even break your script. 

> [!NOTE]
> **Use Sparingly:** Only preserve what’s absolutely necessary. Overusing `mdk preserve` can reduce the Minifier’s effectiveness.
