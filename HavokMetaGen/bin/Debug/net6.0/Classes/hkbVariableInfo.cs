using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbVariableInfo
	{
		public const string version = "1";
		public hkbRoleAttribute m_role { get; set; }
		public const string m_role_Name = "role";
		public const string m_role_Type = "struct";
		public const string m_role_Class = "hkbRoleAttribute";
		public int m_type { get; set; }
		public const string m_type_Name = "type";
		public const string m_type_Type = "int";

	}
}
