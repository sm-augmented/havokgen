using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbModifierList: hkbModifier
	{
		public const string version = "0";
		public List<hkbModifier> m_modifiers { get; set; }
		public const string m_modifiers_Name = "modifiers";
		public const string m_modifiers_Type = "ref";
		public List<int> m_modifiers_refId { get; set; }
		public const string m_modifiers_Class = "hkbModifier";
		public const string m_modifiers_Array = "True";

	}
}
