using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCharacterStringData: hkReferencedObject
	{
		public const string version = "5";
		public List<string> m_deformableSkinNames { get; set; }
		public const string m_deformableSkinNames_Name = "deformableSkinNames";
		public const string m_deformableSkinNames_Type = "string";
		public const string m_deformableSkinNames_Array = "True";
		public List<string> m_rigidSkinNames { get; set; }
		public const string m_rigidSkinNames_Name = "rigidSkinNames";
		public const string m_rigidSkinNames_Type = "string";
		public const string m_rigidSkinNames_Array = "True";
		public List<string> m_animationNames { get; set; }
		public const string m_animationNames_Name = "animationNames";
		public const string m_animationNames_Type = "string";
		public const string m_animationNames_Array = "True";
		public List<string> m_animationFilenames { get; set; }
		public const string m_animationFilenames_Name = "animationFilenames";
		public const string m_animationFilenames_Type = "string";
		public const string m_animationFilenames_Array = "True";
		public List<string> m_characterPropertyNames { get; set; }
		public const string m_characterPropertyNames_Name = "characterPropertyNames";
		public const string m_characterPropertyNames_Type = "string";
		public const string m_characterPropertyNames_Array = "True";
		public List<string> m_retargetingSkeletonMapperFilenames { get; set; }
		public const string m_retargetingSkeletonMapperFilenames_Name = "retargetingSkeletonMapperFilenames";
		public const string m_retargetingSkeletonMapperFilenames_Type = "string";
		public const string m_retargetingSkeletonMapperFilenames_Array = "True";
		public List<string> m_lodNames { get; set; }
		public const string m_lodNames_Name = "lodNames";
		public const string m_lodNames_Type = "string";
		public const string m_lodNames_Array = "True";
		public List<string> m_mirroredSyncPointSubstringsA { get; set; }
		public const string m_mirroredSyncPointSubstringsA_Name = "mirroredSyncPointSubstringsA";
		public const string m_mirroredSyncPointSubstringsA_Type = "string";
		public const string m_mirroredSyncPointSubstringsA_Array = "True";
		public List<string> m_mirroredSyncPointSubstringsB { get; set; }
		public const string m_mirroredSyncPointSubstringsB_Name = "mirroredSyncPointSubstringsB";
		public const string m_mirroredSyncPointSubstringsB_Type = "string";
		public const string m_mirroredSyncPointSubstringsB_Array = "True";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public string m_rigName { get; set; }
		public const string m_rigName_Name = "rigName";
		public const string m_rigName_Type = "string";
		public string m_ragdollName { get; set; }
		public const string m_ragdollName_Name = "ragdollName";
		public const string m_ragdollName_Type = "string";
		public string m_behaviorFilename { get; set; }
		public const string m_behaviorFilename_Name = "behaviorFilename";
		public const string m_behaviorFilename_Type = "string";

	}
}
