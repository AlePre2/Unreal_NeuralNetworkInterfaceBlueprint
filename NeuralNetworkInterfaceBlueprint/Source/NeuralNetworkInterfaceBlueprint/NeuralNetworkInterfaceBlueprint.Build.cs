// Some copyright should be here...

using UnrealBuildTool;
using System.IO;

public class NeuralNetworkInterfaceBlueprint : ModuleRules
{
	public NeuralNetworkInterfaceBlueprint(ReadOnlyTargetRules Target) : base(Target)
	{
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);


        PrivateIncludePaths.AddRange(
           new string[] {
				//"../../../../../Source/Runtime/Renderer/Private",
				Path.Combine(EngineDirectory, "Source/Runtime/Renderer/Private"),
			   // ... add other private include paths required here ...
		   }
       );


        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        //added to supress warnings from opencv plugin
        bEnableUndefinedIdentifierWarnings = false;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
            "Core",
            "CoreUObject", "Engine", "OpenCV", "OpenCVHelper", "InputCore", "HeadMountedDisplay", "NeuralNetworkInference"
            }
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
                                        "Core",
                                        "CoreUObject",
                                        "Engine",
                                        "Renderer",
                                        "RenderCore",
                                        "RHI",
                                        "RHICore",
                                        "D3D12RHI",
                                        "OpenCV",
                                        "OpenCVHelper" 
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
