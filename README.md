## Enumerator Utils

[![NuGet](https://img.shields.io/nuget/v/wk.EnumeratorUtils.svg)](https://www.nuget.org/packages/wk.EnumeratorUtils)

## Installation

```bash
dotnet add package wk.EnumeratorUtils
```

## Usage

```csharp
using EnumeratorUtils;

IEnumerator ints = ...
IEnumerable<int> e = ints.Cast<int>();
```
