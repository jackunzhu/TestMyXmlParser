// Copyright 1998-2020 Byoliontech. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class testpluginTarget : TargetRules
{
	public testpluginTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "testplugin" } );
	}
}
