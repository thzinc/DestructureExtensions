# DestructureExtensions

Destructuring extension methods for awesome C#

## Quickstart

In C# 7.0:

```csharp
using DestructureExtensions;

/*...*/
var stringToSplit = "foo,bar,bam,baz";
var (first, _, third, rest) = stringToSplit.Split(',');

// first == "foo"
// third == "bam"
// rest == IEnumerable<string> containing "baz"

var one = Task.FromResult(1);
var two = Task.FromResult("foo");
var three = Task.FromResult(DateTimeOffset.Now);

var (first, second, third) = await (one, two, three).WhenAll();

var tasks = Enumerable.Range(1, 10).Select(Task.FromResult);
var results = await tasks.WhenAll();
```

## Building

[![Travis](https://img.shields.io/travis/thzinc/DestructureExtensions.svg)](https://travis-ci.org/thzinc/DestructureExtensions)
[![NuGet](https://img.shields.io/nuget/v/DestructureExtensions.svg)](https://www.nuget.org/packages/DestructureExtensions/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/DestructureExtensions.svg)](https://www.nuget.org/packages/DestructureExtensions/)

Ensure you have [installed .NET Core](https://www.microsoft.com/net/core)

To build a local/development NuGet package, run the following:

```bash
dotnet restore
dotnet build
dotnet pack
```

This will produce `bin/Debug/DestructureExtensions.0.0.0.nupkg`.

## Code of Conduct

We are committed to fostering an open and welcoming environment. Please read our [code of conduct](CODE_OF_CONDUCT.md) before participating in or contributing to this project.

## Contributing

We welcome contributions and collaboration on this project. Please read our [contributor's guide](CONTRIBUTING.md) to understand how best to work with us.

## License and Authors

[![Daniel James logo](https://secure.gravatar.com/avatar/eaeac922b9f3cc9fd18cb9629b9e79f6.png?size=16) Daniel James](http://thzinc.com)

[![license](https://img.shields.io/github/license/thzinc/DestructureExtensions.svg)](https://github.com/thzinc/DestructureExtensions/blob/master/LICENSE)
[![GitHub contributors](https://img.shields.io/github/contributors/thzinc/DestructureExtensions.svg)](https://github.com/thzinc/DestructureExtensions/graphs/contributors)

This software is made available by Daniel James under the MIT license.