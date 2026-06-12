

using UnrealBuildTool;
using System.Collections.Generic;

public class ALSV_NoteEditorTarget : TargetRules
{
	public ALSV_NoteEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ALSV_Note" } );
	}
}
