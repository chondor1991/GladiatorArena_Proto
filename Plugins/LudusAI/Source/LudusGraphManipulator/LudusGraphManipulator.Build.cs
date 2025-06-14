using UnrealBuildTool;

public class LudusGraphManipulator : ModuleRules
{
    public LudusGraphManipulator(ReadOnlyTargetRules Target) : base(Target)
    {
		bUsePrecompiled = true;
		PrecompileForTargets = PrecompileTargetsType.Any;
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        // Core engine dependencies

        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "Slate",
            "SlateCore",
            "InputCore",
            "UMG",
            "UnrealEd",
            "BlueprintGraph",
            "GraphEditor",
            "Kismet", // Blueprint system
            "KismetCompiler", 
            "LudusDatabase", // Blueprint compilation
            "BlueprintEditorLibrary", // Blueprint editor utilities
            "SQLiteCore",
            "SQLiteSupport",
            "Json",
            "JsonUtilities",
            "LudusCore"
        });


        // Editor-only dependencies
        if (Target.Type == TargetType.Editor)
        {
            PrivateDependencyModuleNames.AddRange(new string[]
            {
                "UnrealEd",
                "EditorSubsystem",
                "Kismet",
                "KismetCompiler",
                "BlueprintGraph",
                "GraphEditor",
            });

        }

    }
}