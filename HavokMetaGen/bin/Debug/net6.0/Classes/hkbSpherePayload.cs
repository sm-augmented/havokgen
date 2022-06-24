using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbSpherePayload: hkbShapePayload
	{
		public const string version = "0";
		public List<float> m_originOffset { get; set; }
		public const string m_originOffset_Name = "originOffset";
		public const string m_originOffset_Type = "vec4";
		public float m_radius { get; set; }
		public const string m_radius_Name = "radius";
		public const string m_radius_Type = "real";

	}
}
