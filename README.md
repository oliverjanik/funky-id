# FunkyId

[![NuGet](https://img.shields.io/nuget/v/AidDev.FunkyId.svg)](https://www.nuget.org/packages/AidDev.FunkyId)
[![CI](https://github.com/oliverjanik/funky-id/actions/workflows/ci.yml/badge.svg)](https://github.com/oliverjanik/funky-id/actions/workflows/ci.yml)

Memorable identifier generator for .NET. Produces human-friendly IDs in the format `adjective_noun_tag`.

```
zippy_zebra_a7k2
bouncy_axolotl_f9m1
jazzy_capybara_q4x8
```

## Installation

```bash
dotnet add package AidDev.FunkyId
```

## Usage

```csharp
using AidDev.FunkyId;

// Generate an ID with the default 4-character tag
string id = FunkyIdGenerator.Generate();
// → "snazzy_platypus_k3w9"

// Generate with a longer tag for lower collision probability
string longId = FunkyIdGenerator.Generate(randomTagLength: 8);
// → "fluffy_narwhal_bx72qm4p"
```

## Why?

UUIDs are great for machines. FunkyIds are great for humans — easy to read, remember, and say out loud. Useful for temporary resource names, container names, log correlation, or anywhere a friendly identifier beats a wall of hex.

## License

MIT
