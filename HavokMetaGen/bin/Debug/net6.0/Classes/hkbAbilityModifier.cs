using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAbilityModifier: hkbModifier
	{
		public const string version = "1";
		public string m_abilityKey { get; set; }
		public const string m_abilityKey_Name = "abilityKey";
		public const string m_abilityKey_Type = "string";
		public int m_wargearSource { get; set; }
		public const string m_wargearSource_Name = "wargearSource";
		public const string m_wargearSource_Type = "int";
		public int m_test { get; set; }
		public const string m_test_Name = "test";
		public const string m_test_Type = "int";

	}
}
