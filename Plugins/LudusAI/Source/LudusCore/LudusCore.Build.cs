using System;
using System.IO;
using UnrealBuildTool;

public class LudusCore : ModuleRules
{
	public LudusCore(ReadOnlyTargetRules Target) : base(Target)
	{
		bUsePrecompiled = true;
		PrecompileForTargets = PrecompileTargetsType.Any;
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"HTTP",
			"HTTPServer",
			"Json",
			"JsonUtilities",
			"EditorScriptingUtilities",
			"Projects",
		});

		PrivateDependencyModuleNames.AddRange(new string[]
		{
			"Slate",
			"SlateCore", 
			"DeveloperSettings",
			"UnrealEd",
			"EditorSubsystem",
			"Projects"
		});
		
	}
}