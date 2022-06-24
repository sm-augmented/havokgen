using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbRoleAttribute
	{
		public const string version = "0";
		public int m_role { get; set; }
		public const string m_role_Name = "role";
		public const string m_role_Type = "int";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";

	}
}
