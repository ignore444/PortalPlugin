// Released under MIT License
// Copyright (c) Pascal Krabbe 2017

using UnrealBuildTool;
using System.Collections.Generic;

public class PortalsEditorTarget : TargetRules
{
	public PortalsEditorTarget(TargetInfo Target) : base(Target)
	{
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
        ExtraModuleNames.AddRange( new string[] { "Portals" } );
	}
}
