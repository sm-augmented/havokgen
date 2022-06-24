using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCharacter: hkReferencedObject
	{
		public const string version = "2";
		public List<hkbCharacter> m_nearbyCharacters { get; set; }
		public const string m_nearbyCharacters_Name = "nearbyCharacters";
		public const string m_nearbyCharacters_Type = "ref";
		public List<int> m_nearbyCharacters_refId { get; set; }
		public const string m_nearbyCharacters_Class = "hkbCharacter";
		public const string m_nearbyCharacters_Array = "True";
		public int m_currentLod { get; set; }
		public const string m_currentLod_Name = "currentLod";
		public const string m_currentLod_Type = "int";
		public int m_numTracksInLod { get; set; }
		public const string m_numTracksInLod_Name = "numTracksInLod";
		public const string m_numTracksInLod_Type = "int";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public hkbCharacterSetup m_setup { get; set; }
		public const string m_setup_Name = "setup";
		public const string m_setup_Type = "ref";
		public int m_setup_refId { get; set; }
		public const string m_setup_Class = "hkbCharacterSetup";
		public hkbBehaviorGraph m_behaviorGraph { get; set; }
		public const string m_behaviorGraph_Name = "behaviorGraph";
		public const string m_behaviorGraph_Type = "ref";
		public int m_behaviorGraph_refId { get; set; }
		public const string m_behaviorGraph_Class = "hkbBehaviorGraph";
		public hkbProjectData m_projectData { get; set; }
		public const string m_projectData_Name = "projectData";
		public const string m_projectData_Type = "ref";
		public int m_projectData_refId { get; set; }
		public const string m_projectData_Class = "hkbProjectData";
		public byte m_deleteWorldFromModel { get; set; }
		public const string m_deleteWorldFromModel_Name = "deleteWorldFromModel";
		public const string m_deleteWorldFromModel_Type = "byte";
		public byte m_deletePoseLocal { get; set; }
		public const string m_deletePoseLocal_Name = "deletePoseLocal";
		public const string m_deletePoseLocal_Type = "byte";
		public byte m_characterStuck { get; set; }
		public const string m_characterStuck_Name = "characterStuck";
		public const string m_characterStuck_Type = "byte";

	}
}
