using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpCapsuleShape: hkpConvexShape
	{
		public const string version = "0";
		public List<float> m_vertexA { get; set; }
		public const string m_vertexA_Name = "vertexA";
		public const string m_vertexA_Type = "vec4";
		public List<float> m_vertexB { get; set; }
		public const string m_vertexB_Name = "vertexB";
		public const string m_vertexB_Type = "vec4";

	}
}
