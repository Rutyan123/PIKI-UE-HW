// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyFirstUeProjectMLgP : ModuleRules
{
	public MyFirstUeProjectMLgP(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MyFirstUeProjectMLgP",
			"MyFirstUeProjectMLgP/Variant_Platforming",
			"MyFirstUeProjectMLgP/Variant_Platforming/Animation",
			"MyFirstUeProjectMLgP/Variant_Combat",
			"MyFirstUeProjectMLgP/Variant_Combat/AI",
			"MyFirstUeProjectMLgP/Variant_Combat/Animation",
			"MyFirstUeProjectMLgP/Variant_Combat/Gameplay",
			"MyFirstUeProjectMLgP/Variant_Combat/Interfaces",
			"MyFirstUeProjectMLgP/Variant_Combat/UI",
			"MyFirstUeProjectMLgP/Variant_SideScrolling",
			"MyFirstUeProjectMLgP/Variant_SideScrolling/AI",
			"MyFirstUeProjectMLgP/Variant_SideScrolling/Gameplay",
			"MyFirstUeProjectMLgP/Variant_SideScrolling/Interfaces",
			"MyFirstUeProjectMLgP/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
