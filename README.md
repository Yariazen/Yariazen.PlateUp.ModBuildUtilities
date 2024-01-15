# Yaraizen.PlateUp.ModBuildUtilities

| Property				| Type		| Description |
| ---					| ---		| --- |
| GamePath				| String	| The directory where the PlateUp executable is located |
| WorkshopPath			| String	| Your PlateUp workshop directory |
| AssemblyReferencePath | String	| Your PlateUp_Data/Managed directory |
| GameModsPath			| String	| The Mods folder located in the same directory as your PlateUp executable |
| AssetBundlePath		| String	| The path to the AssetBundle for your mod |
| ThirdPartyPath		| String	| The path to third party dlls for your mod |

| Utility				| Type		| Default	| Description |
| ---					| ---		| ---		| --- |
| EnableModDeployLocal	| Bool		| True		| Automatically deploy to your Mods directory |
| EnableAutoPDB			| Bool		| True		| Automatically deploys your PDB to your Mods directory |
| EnableGameDebugging	| Bool		| False		| Automatically attach Roslyn debugger for the Visual Studio IDE |
| EnableCopyLocal		| Bool		| False		| Copy dependencies to your build directory |
| EnableDocumentation	| Bool		| False		| Generate XML documentation |
| EnableAutoReference   | Bool		| True		| Automatically references PlateUp! dlls, workshop mods, and local mods |

# Blacklist
Specific DLLs can be blacklisted from the auto reference. Make a new ItemGroup and include a Blacklist item with the DLL you wish to exclude. By default the following are excluded.

```xml
<ItemGroup>
	<Blacklist Include="$(AssemblyReferencePath)\System.Buffers.dll" />
	<Blacklist Include="$(AssemblyReferencePath)\Microsoft.Extensions.Logging.Abstractions.dll" />
	<Blacklist Include="$(AssemblyReferencePath)\Mono.Posix.dll" />
	<Blacklist Include="$(AssemblyReferencePath)\Mono.Security.dll" />
</ItemGroup>
```

### Examples
Blacklist a single DLL
```xml
<ItemGroup>
	<Blacklist Include="$(AssemblyReferencePath)\System.Buffers.dll" />
<\ItemGroup>
```

Blacklist multiple specific DLL
```xml
<ItemGroup>
	<Blacklist Include="$(AssemblyReferencePath)\System.Buffers.dll" />
	<Blacklist Include="$(AssemblyReferencePath)\Microsoft.Extensions.Logging.Abstractions.dll" />
	<Blacklist Include="$(AssemblyReferencePath)\Mono.Posix.dll" />
	<Blacklist Include="$(AssemblyReferencePath)\Mono.Security.dll" />
</ItemGroup>
```

Blacklist with wild card
```xml
<ItemGroup>
	<Blacklist Include="$(AssemblyReferencePath)\Unity*.dll" />
<\ItemGroup>
```

Blacklist with wild card and exclude
```xml
<ItemGroup>
	<Blacklist Include="$(AssemblyReferencePath)\Unity*.dll" Exclude="$(AssemblyReferencePath)\Unity.Entities.dll" />
<\ItemGroup>
```