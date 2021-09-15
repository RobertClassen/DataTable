# DataTable for Unity

## Compatibility

Tested with:
* Unity 2018  
	Requires Scripting Runtime Version ".NET 4.x Equivalent". Does not work with ".NET 3.5 Equivalent (Deprecated)" due to usage of `nameof` keyword which requires C# 6 or later (see [here](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)).
* Unity 2019
* Unity 2020
* Unity 2021

## Installation

### Installation via Git URL (recommended)
See [here](https://docs.unity3d.com/Manual/upm-ui-giturl.html) for how to install packages via Git URL by using the Unity Package Manager.  
See [here](https://docs.unity3d.com/Manual/upm-git.html) for how to do so manually by editing the "manifest.json" file in `[your project folder]/Packages/`.

### Installation from a local package (alternative)
See [here](https://docs.unity3d.com/Manual/upm-ui-local.html) for how to install packages from a local folder using the Unity Package Manager.  
See [here](https://docs.unity3d.com/Manual/upm-localpath.html) for how to do so manually by editing the "manifest.json" file in `[your project folder]/Packages/`.

## Usage

1. Add references to the custom `namespaces` as needed:
    ```csharp
	using DataTypes;
	```