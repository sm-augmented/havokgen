using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpBoxShape: hkpConvexShape
	{
		public const string version = "0";
		public List<float> m_halfExtents { get; set; }
		public const string m_halfExtents_Name = "halfExtents";
		public const string m_halfExtents_Type = "vec4";

	}
}
