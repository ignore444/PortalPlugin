// Released under MIT License
// Copyright (c) Pascal Krabbe 2017

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class PortalPlugin : ModuleRules
	{
		public PortalPlugin(ReadOnlyTargetRules Target) : base(Target)
		{
			PublicIncludePaths.AddRange(
			   new string[] {
					Path.Combine(ModuleDirectory, "Public")
				}
                );

			PrivateIncludePaths.AddRange(
				new string[] {
					Path.Combine(ModuleDirectory, "Private")
				}
                );

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
					"HeadMountedDisplay"
					// ... add other public dependencies that you statically link with here ...
				}
                );

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
		}
	}
}
