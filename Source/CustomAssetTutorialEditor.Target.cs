// Copyright (c) 2015 Benjamin Reeves

using UnrealBuildTool;
using System.Collections.Generic;

public class CustomAssetTutorialEditorTarget : TargetRules
{
	public CustomAssetTutorialEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "CustomAssetTutorial" } );
	}
}
