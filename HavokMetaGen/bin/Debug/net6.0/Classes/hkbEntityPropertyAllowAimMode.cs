using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertyAllowAimMode: hkbEntityPropertyControlData
	{
		public const string version = "0";
		public int m_restriction { get; set; }
		public const string m_restriction_Name = "restriction";
		public const string m_restriction_Type = "int";

	}
}
