

using UnrealBuildTool;
using System.Collections.Generic;

public class ALSV_NoteTarget : TargetRules
{
	public ALSV_NoteTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ALSV_Note" } );
	}
}
