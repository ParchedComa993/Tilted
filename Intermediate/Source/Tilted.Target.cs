using UnrealBuildTool;

public class TiltedTarget : TargetRules
{
	public TiltedTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Tilted");
	}
}
