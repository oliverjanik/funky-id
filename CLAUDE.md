# FunkyId

Memorable identifier generator library. Produces IDs in the format `adjective_noun_tag` (e.g. `zippy_zebra_a7k2`).

## Projects

- `FunkyId/` — class library (net8.0), published as NuGet package `AidDev.FunkyId`
- `Tests/` — xUnit test project (net10.0, requires .NET 10 SDK)

## Commands

```bash
# Build
dotnet build

# Test (requires .NET 10 SDK)
dotnet test

# Pack NuGet
dotnet pack FunkyId/FunkyId.csproj
```

## conventions

- Word lists in `FunkyIdGenerator.cs` are kept alphabetically sorted
- Do not add the co-authored-by trailer to git commits
