# Yaraizen.PlateUp.ModBuildUtilities

| Property				| Type		| Default	| Description |
| ---					| ---		| ---		| --- |
| GamePath				| String	|			| The directory where the PlateUp executable is located |
| WorkshopPath			| String	|			| Your PlateUp workshop directory |
| AssemblyReferencePath | String	|			| Your PlateUp_Data/Managed directory |
| GameModsPath			| String	|			| The Mods folder located in the same directory as your PlateUp executable |
| AssetBundlePath		| String	|			| The path to the AssetBundle for your mod |
| EnableModDeployLocal	| Bool		| True		| Automatically deploy to your Mods directory |
| EnableGameDebugging	| Bool		| True		| Automatically attach Roslyn debugger for the Visual Studio IDE |
| EnableCopyLocal		| Bool		| False		| Copy dependencies to your build directory |
| EnableDocumentation	| Bool		| True		| Generate XML documentation |
