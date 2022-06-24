using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttributeModifier: hkbModifier
	{
		public const string version = "0";
		public List<hkbAttributeModifierAssignment> m_assignments { get; set; }
		public const string m_assignments_Name = "assignments";
		public const string m_assignments_Type = "struct";
		public const string m_assignments_Class = "hkbAttributeModifierAssignment";
		public const string m_assignments_Array = "True";

	}
}
