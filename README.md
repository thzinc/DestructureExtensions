# DestructureExtensions

[![NuGet](https://img.shields.io/nuget/v/DestructureExtensions.svg)](https://www.nuget.org/packages/DestructureExtensions/)

Destructuring extension methods for awesome C#

# Quickstart

In C# 7.0:

```csharp
using DestructureExtensions;

/*...*/
var stringToSplit = "foo,bar,bam,baz";
var (first, _, third, rest) = stringToSplit.Split(',');

// first == "foo"
// third == "bam"
// rest == IEnumerable<string> containing "baz"
```
