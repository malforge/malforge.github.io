You can influence the order in which your `.cs` files are combined when building your MDK² project by specifying a sort order at the top of your files. For example:

```csharp
// <mdk sortorder="1000" />
```

This directive assigns a sorting weight to the file, determining its position during the combination process. Lower values are processed first.

## Important Limitation
In Space Engineers, the `Program` class and its contents **must appear first** in the final combined script. This means:
- Any file containing types or code **outside** the `Program` class cannot be placed **before** files containing the `Program` class or its nested types, regardless of the sort order you assign.

---

This mechanism gives you a degree of control over file order while respecting the constraints imposed by Space Engineers' scripting requirements.
