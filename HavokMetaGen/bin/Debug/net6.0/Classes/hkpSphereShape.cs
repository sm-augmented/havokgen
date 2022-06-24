using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpSphereShape: hkpConvexShape
	{
		public const string version = "0";
		public List<int> m_pad16 { get; set; }
		public const string m_pad16_Name = "pad16";
		public const string m_pad16_Type = "int";
		public const string m_pad16_Count = "3";

	}
}
