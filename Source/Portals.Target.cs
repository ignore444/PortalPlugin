// Released under MIT License
// Copyright (c) Pascal Krabbe 2017

using UnrealBuildTool;
using System.Collections.Generic;

public class PortalsTarget : TargetRules
{
	public PortalsTarget(TargetInfo Target) : base(Target)
	{
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
        ExtraModuleNames.AddRange( new string[] { "Portals" } );
	}
}
